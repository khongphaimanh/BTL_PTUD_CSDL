using DevExpress.ClipboardSource.SpreadsheetML;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXQLMT.BackEnd.BillDAO
{
    public class BillDAO
    {
        private BillDAO() { }
        private static BillDAO instance;

        public static BillDAO Instance { get => instance ?? (instance = new BillDAO()); private set => instance = value; }
        public DataTable load_dgv_bill()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT Bill.Id, Bill.NameCustomer, Bill.NgayBan, Bill.sdt_khachhang, Bill.TongTien, Bill.GhiChu, " +
               "BillInfor.Id_product, BillInfor.Quantity, BillInfor.ThanhTien " +
               "FROM Bill " +
               "INNER JOIN BillInfor ON Bill.Id = BillInfor.Id_Bill";
            dataTable = DataProvide.Instance.ExecuteQuery(query);
            return dataTable;
        }
        public bool check_Quantity(int msp, int sl)
        {
            string query = "select Quantity from Products where Id = @msp ";
            int quantity = (int)DataProvide.Instance.ExecuteScalar(query, new object[] { msp});
            if (quantity >= sl) return true;
            return false;
        }
        public void add_product(string Id_Bill, int msp, int sl)
        {
            decimal thanhtien = 0;
            string query = "select GiaBan from Products where Id = @msp ";
            decimal price = (decimal)DataProvide.Instance.ExecuteScalar(query, new object[] { msp });
            thanhtien = price * sl;
            query = "insert into TempTable values( @msp , @Id_Bill , @sl , @ThanhTien );";
            DataProvide.Instance.ExecuteNonQuery(query, new object[] { msp, Id_Bill, sl, thanhtien });
            query = "update Products set Quantity = Quantity - @sl where Id = @msp ";
            DataProvide.Instance.ExecuteNonQuery(query, new object[] { sl, msp });
        }
        public DataTable temp_product()
        {
            DataTable data = new DataTable();
            string query = "select * from TempTable";
            data = DataProvide.Instance.ExecuteQuery(query);
            return data;
        }
        public void copy_data(string Id, string name, DateTime date, string sdt, string ghichu)
        {
            string query = "insert into BillInfor(Id_Bill, Id_product, Quantity, ThanhTien) select" +
                " Id_Bill, msp, sl, ThanhTien from TempTable";
            DataProvide.Instance.ExecuteNonQuery(query);
            query = "delete from TempTable";
            DataProvide.Instance.ExecuteNonQuery(query);
            decimal Total = 0;
            query = "select SUM(ThanhTien) from BillInfor ";
            Total = (decimal)DataProvide.Instance.ExecuteScalar(query);
            query = "insert into Bill values( @Id , @Name , @NgayBan , @sdt , @tongtien , @ghichu )";
            DataProvide.Instance.ExecuteNonQuery(query, new object[]{ Id, name, date, sdt, Total, ghichu});
        }
    }
}
