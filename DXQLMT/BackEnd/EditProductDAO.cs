using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXQLMT.BackEnd
{
    public class EditProductDAO
    {
        private EditProductDAO() { }
        private static EditProductDAO instance;

        public static EditProductDAO Instance { get => instance ??(instance = new EditProductDAO()); private set => instance = value; }
        public void Add_Product(int Id, string Name, byte[] img, int sl, string mota, decimal giaban)
        {
            string query = "insert into Products values( @Id , @Name , @img , @sl , @mota , @giaban );";
            
            DataProvide.Instance.ExecuteNonQuery(query, new object[] { Id, Name, img, sl, mota, giaban });
        }
        public bool check_Id(int Id)
        {
            string query = "select *from Products where Id = @Id ";
            if (DataProvide.Instance.ExecuteQuery(query, new object[] { Id}).Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public void del_Products(int Id)
        {
            string query = "delete from Products where Id = @Id ";
            DataProvide.Instance.ExecuteNonQuery(query, new object[] { Id });
        }
        public void Update_Product(int Id, string Name, byte[] img, int sl, string mota, decimal giaban)
        {
            string query = "update Products set ProductName = @Name , ProductImage = @img , Quantity = @sl , MoTa = @mota , GiaBan = @giaban where Id = @Id ";
            DataProvide.Instance.ExecuteNonQuery(query, new object[] { Name, img, sl, mota, giaban, Id });
        }
        public void Update_Product1(int Id, string Name, int sl, string mota, decimal giaban)
        {
            string query = "update Products set ProductName = @Name , Quantity = @sl , MoTa = @mota , GiaBan = @giaban where Id = @Id ";
            DataProvide.Instance.ExecuteNonQuery(query, new object[] { Name, sl, mota, giaban, Id });
        }
    }
}
