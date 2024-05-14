﻿using BantuanRumahLayakHuni.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Mvc;

namespace BantuanRumahLayakHuni.ViewModels
{

    public class VMKriteria
    {
        DB_SPK_PBRLHDataContext db = new DB_SPK_PBRLHDataContext(ConfigurationManager.ConnectionStrings["DB_SPK_PBRLHConnectionString"].ConnectionString);
        public IList<TBL_M_KRITERIA> Kriterias { get; set; }
        public IList<TBL_M_KRITERIA_DETAIL> KriteriaDetails { get; set; }

        public IList<TBL_M_KRITERIA> GetKriteria()
        {

            var kriteria = db.TBL_M_KRITERIAs.ToList();
            return kriteria;
        }

        public List<VW_REKOMENDASI_SAW> GetRekomendasiSAW()
        {
            var data = db.VW_REKOMENDASI_SAWs.OrderBy(a => a.Rank).ToList();
            return data;
        }

        public List<VW_NILAI_KRITERIA> GetNilaiKriteria(int id)
        {
            var data = db.VW_NILAI_KRITERIAs.Where(a => a.ID_CALON_PENERIMA == id).OrderBy(a => a.ID_KRITERIA).ToList();
            return data;
        }

        public IList<TBL_M_KRITERIA_DETAIL> GetKriteriaDetails()
        {
            var detail = db.TBL_M_KRITERIA_DETAILs.ToList();
            return detail;
        }

        public void InsertAlternative(FormCollection form)
        {
            string name = form["name"];
            string jk = form["jk"];
            string alamat = form["alamat"];
            int usia = int.Parse(form["usia"]);

            TBL_M_CALON_PENERIMA tbl = new TBL_M_CALON_PENERIMA
            {
                NAMA = name,
                JENIS_KELAMIN = jk,
                ALAMAT = alamat,
                USIA = usia
            };

            var idUser = AddCalonPenerimaBantuan(tbl);

            List<TBL_T_KRITERIA> kriteriaList = new List<TBL_T_KRITERIA>();

            foreach (string key in form.Keys)
            {
                if (int.TryParse(key, out int kriteriaId))
                {
                    string nilai = form[key];

                    var kriteriaDetail = new TBL_T_KRITERIA
                    {
                        ID_CALON_PENERIMA = idUser,
                        ID_KRITERIA = kriteriaId,
                        NILAI_KRITERIA = Int32.Parse(nilai)
                    };

                    kriteriaList.Add(kriteriaDetail);
                }
            }

            AddNilaiKriteria(kriteriaList);
            HitungNilaiSAW();
        }
        
        public void UpdateAlternative(FormCollection form)
        {
            int id = int.Parse(form["id"]);
            string name = form["name"];
            string jk = form["jk"];
            string alamat = form["alamat"];
            int usia = int.Parse(form["usia"]);

            TBL_M_CALON_PENERIMA tbl = new TBL_M_CALON_PENERIMA
            {
                ID = id,
                NAMA = name,
                JENIS_KELAMIN = jk,
                ALAMAT = alamat,
                USIA = usia
            };

            var idUser = UpdateCalonPenerimaBantuan(tbl);

            List<TBL_T_KRITERIA> kriteriaList = new List<TBL_T_KRITERIA>();

            foreach (string key in form.Keys)
            {
                if (int.TryParse(key, out int kriteriaId))
                {
                    string nilai = form[key];

                    var kriteriaDetail = new TBL_T_KRITERIA
                    {
                        ID_CALON_PENERIMA = idUser,
                        ID_KRITERIA = kriteriaId,
                        NILAI_KRITERIA = Int32.Parse(nilai)
                    };

                    kriteriaList.Add(kriteriaDetail);
                }
            }

            UpdateNilaiKriteria(kriteriaList);
            HitungNilaiSAW();
        }

        public void AddNilaiKriteria(IList<TBL_T_KRITERIA> tbl)
        {
            db.TBL_T_KRITERIAs.InsertAllOnSubmit(tbl);
            db.SubmitChanges();
        }

        public void HitungNilaiSAW()
        {
            TruncateTHasil();
            var dataNilai = db.TBL_T_KRITERIAs.ToList();
            var dataKriteria = db.TBL_M_KRITERIAs.ToList();
            var dataCalon = db.TBL_M_CALON_PENERIMAs.ToList();

            var minmaxNilaiKriteria = db.TBL_T_KRITERIAs
                .GroupBy(k => k.ID_KRITERIA)
                .Select(g => new
                    {
                        ID_KRITERIA = g.Key, 
                        MAX_NILAI = g.Max(k => k.NILAI_KRITERIA),
                        MIN_NILAI = g.Min(k => k.NILAI_KRITERIA)
                }
                );

            List<TBL_T_HASIL> dataHasil = new List<TBL_T_HASIL>();

            foreach (var calon in dataCalon)
            {
                float nilaiSAW = 0;
                var dataNilaiCalon = dataNilai.Where(a => a.ID_CALON_PENERIMA == calon.ID).ToList();
                foreach (var nilai in dataNilaiCalon)
                {
                    var kriteria = dataKriteria.Where(a => a.ID == nilai.ID_KRITERIA).FirstOrDefault();
                    var nilaiKriteria = minmaxNilaiKriteria.Where(a => a.ID_KRITERIA == nilai.ID_KRITERIA).FirstOrDefault();
                    if (kriteria.SIFAT == "Benefit")
                    {
                        var normalisasi = (float)nilai.NILAI_KRITERIA / (float)nilaiKriteria.MAX_NILAI;
                        var normalisasiBobot = normalisasi * ((float)kriteria.BOBOT / 100f);
                        nilaiSAW += normalisasiBobot;
                    }
                    else
                    {
                        var normalisasi = (float)nilaiKriteria.MIN_NILAI / (float)nilai.NILAI_KRITERIA;
                        var normalisasiBobot = normalisasi * ((float)kriteria.BOBOT / 100f);
                        nilaiSAW += normalisasiBobot;
                    }
                }

                TBL_T_HASIL hasilSAW = new TBL_T_HASIL
                {
                    ID_CALON_PENERIMA = calon.ID,
                    TOTAL_NILAI = nilaiSAW
                };

                dataHasil.Add(hasilSAW);
            }

            db.TBL_T_HASILs.InsertAllOnSubmit(dataHasil);
            db.SubmitChanges();
        }

        public void TruncateTHasil()
        {
            string truncateQuery = "TRUNCATE TABLE TBL_T_HASIL";
            db.ExecuteCommand(truncateQuery);
        }

        public int AddCalonPenerimaBantuan(TBL_M_CALON_PENERIMA tbl)
        {
            db.TBL_M_CALON_PENERIMAs.InsertOnSubmit(tbl);
            db.SubmitChanges();
            return tbl.ID;
        }

        public int UpdateCalonPenerimaBantuan(TBL_M_CALON_PENERIMA tbl)
        {
            var data = db.TBL_M_CALON_PENERIMAs.Where(x => x.ID == tbl.ID).FirstOrDefault();
            data.NAMA = tbl.NAMA;
            data.JENIS_KELAMIN = tbl.JENIS_KELAMIN;
            data.USIA = tbl.USIA;
            data.ALAMAT = tbl.ALAMAT;

            db.SubmitChanges();
            return tbl.ID;
        }

        public void UpdateNilaiKriteria(IList<TBL_T_KRITERIA> tbl)
        {
            foreach (TBL_T_KRITERIA data in tbl)
            {
                var result = db.TBL_T_KRITERIAs.Where(a => a.ID_KRITERIA == data.ID_KRITERIA && a.ID_CALON_PENERIMA == data.ID_CALON_PENERIMA).FirstOrDefault();
                
                result.NILAI_KRITERIA = data.NILAI_KRITERIA;
            }

            db.SubmitChanges();
        }

        public void DeleteAlternative(int id)
        {
            var rTKriteria = db.TBL_T_KRITERIAs.Where(a => a.ID_CALON_PENERIMA == id).ToList();
            db.TBL_T_KRITERIAs.DeleteAllOnSubmit(rTKriteria);

            var rTHasil = db.TBL_T_HASILs.Where(a => a.ID_CALON_PENERIMA == id).FirstOrDefault();
            db.TBL_T_HASILs.DeleteOnSubmit(rTHasil);

            var rMCalon = db.TBL_M_CALON_PENERIMAs.Where(a => a.ID == id).FirstOrDefault();
            db.TBL_M_CALON_PENERIMAs.DeleteOnSubmit(rMCalon);

            db.SubmitChanges();
        }
    }
}