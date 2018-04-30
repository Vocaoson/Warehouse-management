﻿using Main.DAO;
using Main.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.BUS
{
    class HangHoaBUS
    {

        public HangHoaBUS()
        {
            hhDAO = new QuanLyHoaDonContext();
        }
        QuanLyHoaDonContext hhDAO;
        private Exception errorHHBUS;

        public Exception ErrorHHBUS
        {
            get
            {
                return errorHHBUS;
            }

            set
            {
                errorHHBUS = value;
            }
        }

        public List<HangHoa>getAllHangHoa()
        {
            errorHHBUS = null;
            List<HangHoa> hh = null;
            try
            {
                hh = hhDAO.HangHoas.Where(x => x.DaXoa == false).ToList();
            }
            catch (System.Exception ex)
            {
                errorHHBUS = ex;
            }
            return hh;
        }
    }
}
