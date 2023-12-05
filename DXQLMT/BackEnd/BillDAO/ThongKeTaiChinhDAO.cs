using DevExpress.ClipboardSource.SpreadsheetML;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXQLMT.BackEnd.BillDAO
{
    public class ThongKeTaiChinhDAO
    {
        private ThongKeTaiChinhDAO() { }
        private static ThongKeTaiChinhDAO instance;

        public static ThongKeTaiChinhDAO Instance { get => instance ?? (instance = new ThongKeTaiChinhDAO()); private set => instance = value; }
        public decimal ThongKe()
        {
            decimal Total = 0;
            string query = "select SUM(TongTien) from Bill ";
            Total = (decimal)DataProvide.Instance.ExecuteScalar(query);
            return Total;
        }
        public DataTable load_dgv_Bill()
        {
            DataTable dt = new DataTable();
            string query = "select * from Bill";
            dt = DataProvide.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
