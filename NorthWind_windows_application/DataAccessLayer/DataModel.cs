using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;

        public DataModel()
        {
            con = new SqlConnection(ConnectionStrings.ConStr);
            cmd = con.CreateCommand();
        }

        #region Category Function

        public List<Category> GetCategoryList()
        {
            List<Category> categories = new List<Category>();
            try
            {
                cmd.CommandText = "SELECT*FROM Categories";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Category c = new Category();
                    c.CategoryID = reader.GetInt32(0);
                    c.CategoryName = reader.GetString(1);
                    c.Description = reader.GetString(2);
                    categories.Add(c);
                }
                return categories;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable GetCategoryDataTable()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT*FROM Categories";
            cmd.Parameters.Clear();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            return dt;
        }

        public bool AddCategory(Category cat)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Categories(CategoryName,Description)VALUES(@cn,@d)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cn", cat.CategoryName);
                cmd.Parameters.AddWithValue("@d", cat.Description);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public Category GetCategory(int id)
        {
            try
            {
                Category c = new Category();
                cmd.CommandText = "SELECT CategoryID,CategoryName,Description From Categories WHERE CategoryID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    c.CategoryID = reader.GetInt32(0);
                    c.CategoryName = reader.GetString(1);
                    c.Description = reader.IsDBNull(2) ? "" : reader.GetString(2);

                }
                return c;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public void DeleteCategory(int id)
        {
            try
            {
                cmd.CommandText = "DELETE FROM Categories WHERE CategoryID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();

            }
            finally
            {
                con.Close();
            }
        }

        public bool UpdateCategory(Category c)
        {
            try
            {
                cmd.CommandText = "UPDATE Categories SET CategoryName=@cn,Description=@dc WHERE CategoryID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cn", c.CategoryName);
                cmd.Parameters.AddWithValue("@dc", c.Description);
                cmd.Parameters.AddWithValue("@id", c.CategoryID);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        #endregion

        #region Product Function

        public List<Product> GetProductList()
        {
            List<Product> Products = new List<Product>();
            try
            {
                cmd.CommandText = "SELECT P.ProductID,P.Discontinued,P.ProductName,P.CategoryID,P.SupplierID,P.QuantityPerUnit,P.UnitsInStock,P.UnitsOnOrder,P.UnitPrice,P.ReorderLevel,C.CategoryName,S.CompanyName FROM Products AS P JOIN Categories AS C ON P.CategoryID=C.CategoryID JOIN Suppliers AS S ON P.SupplierID=S.SupplierID";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Products.Add(new Product()
                    {
                        ProductID = reader.GetInt32(0),
                        Discontinued = reader.GetBoolean(1),
                        DiscontinuedStr = !reader.GetBoolean(1) ? "Evet" : "Hayır",
                        ProductName = reader.GetString(2),
                        CategoryID = reader.GetInt32(3),
                        SupplierID = reader.GetInt32(4),
                        QuantityPerUnit = reader.IsDBNull(5) ? "-" : reader.GetString(5),
                        UnitsInStock = reader.GetInt16(6),
                        UnitsOnOrder = reader.GetInt16(7),
                        UnitPrice = reader.GetDecimal(8),
                        ReorderLevel = reader.GetInt16(9),
                        Category = reader.GetString(10),
                        Supplier = reader.GetString(11)
                    });
                }
            }
            finally
            {
                con.Close();
            }
            return Products;
        }


        public bool AddProduct(Product product)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Products (ProductName, CategoryID, SupplierID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) VALUES (@pn, @cd, @sd, @qp, @up, @us, @uo, @rl, @d)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("pn", product.ProductName);
                cmd.Parameters.AddWithValue("cd", product.CategoryID);
                cmd.Parameters.AddWithValue("sd", product.SupplierID);
                cmd.Parameters.AddWithValue("qp", product.QuantityPerUnit);
                cmd.Parameters.AddWithValue("up", product.UnitPrice);
                cmd.Parameters.AddWithValue("us", product.UnitsInStock);
                cmd.Parameters.AddWithValue("uo", product.UnitsOnOrder);
                cmd.Parameters.AddWithValue("rl", product.ReorderLevel);
                cmd.Parameters.AddWithValue("d", product.Discontinued);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public Product GetProduct(int id)
        {
            try
            {
                Product p = new Product();
                cmd.CommandText = "SELECT ProductID, ProductName, CategoryID, SupplierID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products WHERE ProductID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    p.ProductID = reader.GetInt32(0);
                    p.ProductName = reader.GetString(1);
                    p.CategoryID = reader.GetInt32(2);
                    p.SupplierID = reader.GetInt32(3);
                    p.QuantityPerUnit = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    p.UnitPrice = reader.GetDecimal(5);
                    p.UnitsInStock = reader.GetInt16(6);
                    p.UnitsOnOrder = reader.GetInt16(7);
                    p.ReorderLevel = reader.GetInt16(8);
                    p.Discontinued = reader.GetBoolean(9);
                }
                return p;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public void DeleteProduct(int id)
        {
            try
            {
                cmd.CommandText = "DELETE FROM Products WHERE ProductID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public bool UpdateProduct(Product p)
        {
            try
            {
                cmd.CommandText = "UPDATE Products SET ProductName=@pn, CategoryID=@cd, SupplierID=@sd, QuantityPerUnit=@qp, UnitPrice=@up, UnitsInStock=@us, UnitsOnOrder=@uo, ReorderLevel=@rl, Discontinued=@d WHERE ProductID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@pn", p.ProductName);
                cmd.Parameters.AddWithValue("@cd", p.CategoryID);
                cmd.Parameters.AddWithValue("@sd", p.SupplierID);
                cmd.Parameters.AddWithValue("@qp", p.QuantityPerUnit);
                cmd.Parameters.AddWithValue("@up", p.UnitPrice);
                cmd.Parameters.AddWithValue("@us", p.UnitsInStock);
                cmd.Parameters.AddWithValue("@uo", p.UnitsOnOrder);
                cmd.Parameters.AddWithValue("@rl", p.ReorderLevel);
                cmd.Parameters.AddWithValue("@d", p.Discontinued);
                cmd.Parameters.AddWithValue("@id", p.ProductID);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        #endregion

        #region Suppliers Function    
        public List<Suppliers> GetSupplierList()
        {
            List<Suppliers> suppliers = new List<Suppliers>();
            try
            {
                cmd.CommandText = @"SELECT s.SupplierID, s.CompanyName, s.ContactName, s.ContactTitle, 
               s.Address, s.City, s.PostalCode, s.Country, s.Phone, s.Fax FROM Suppliers s";

                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    suppliers.Add(new Suppliers()
                    {
                        SupplierID = reader.GetInt32(0),
                        CompanyName = reader.GetString(1),
                        ContactName = reader.IsDBNull(2) ? null : reader.GetString(2),
                        ContactTitle = reader.IsDBNull(3) ? null : reader.GetString(3),
                        Address = reader.IsDBNull(4) ? null : reader.GetString(4),
                        City = reader.IsDBNull(5) ? null : reader.GetString(5),
                        PostalCode = reader.IsDBNull(6) ? null : reader.GetString(6),
                        Country = reader.IsDBNull(7) ? null : reader.GetString(7),
                        Phone = reader.IsDBNull(8) ? null : reader.GetString(8),
                        Fax = reader.IsDBNull(9) ? null : reader.GetString(9)
                    });
                }
            }
            finally
            {
                con.Close();
            }
            return suppliers;
        }

        public bool AddSupplier(Suppliers supplier)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Suppliers (CompanyName, ContactName, ContactTitle, Address, City, PostalCode, Country, Phone, Fax) VALUES (@cn, @cnm, @ct, @a, @c, @pc, @co, @ph, @f)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cn", supplier.CompanyName);
                cmd.Parameters.AddWithValue("@cnm", supplier.ContactName);
                cmd.Parameters.AddWithValue("@ct", supplier.ContactTitle);
                cmd.Parameters.AddWithValue("@a", supplier.Address);
                cmd.Parameters.AddWithValue("@c", supplier.City);
                cmd.Parameters.AddWithValue("@pc", supplier.PostalCode);
                cmd.Parameters.AddWithValue("@co", supplier.Country);
                cmd.Parameters.AddWithValue("@ph", supplier.Phone);
                cmd.Parameters.AddWithValue("@f", supplier.Fax);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public Suppliers GetSupplier(int id)
        {
            try
            {
                Suppliers supplier = null;
                cmd.CommandText = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, PostalCode, Country, Phone, Fax FROM Suppliers WHERE SupplierID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    supplier = new Suppliers()
                    {
                        SupplierID = reader.GetInt32(0),
                        CompanyName = reader.GetString(1),
                        ContactName = reader.IsDBNull(2) ? null : reader.GetString(2),
                        ContactTitle = reader.IsDBNull(3) ? null : reader.GetString(3),
                        Address = reader.IsDBNull(4) ? null : reader.GetString(4),
                        City = reader.IsDBNull(5) ? null : reader.GetString(5),
                        PostalCode = reader.IsDBNull(6) ? null : reader.GetString(6),
                        Country = reader.IsDBNull(7) ? null : reader.GetString(7),
                        Phone = reader.IsDBNull(8) ? null : reader.GetString(8),
                        Fax = reader.IsDBNull(9) ? null : reader.GetString(9)
                    };
                }
                return supplier;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public void DeleteSupplier(int id)
        {
            try
            {
                cmd.CommandText = "DELETE FROM Suppliers WHERE SupplierID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public bool UpdateSupplier(Suppliers supplier)
        {
            try
            {
                cmd.CommandText = "UPDATE Suppliers SET CompanyName=@cn, ContactName=@cnm, ContactTitle=@ct, Address=@a, City=@c, PostalCode=@pc, Country=@co, Phone=@ph, Fax=@f WHERE SupplierID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cn", supplier.CompanyName);
                cmd.Parameters.AddWithValue("@cnm", supplier.ContactName);
                cmd.Parameters.AddWithValue("@ct", supplier.ContactTitle);
                cmd.Parameters.AddWithValue("@a", supplier.Address);
                cmd.Parameters.AddWithValue("@c", supplier.City);
                cmd.Parameters.AddWithValue("@pc", supplier.PostalCode);
                cmd.Parameters.AddWithValue("@co", supplier.Country);
                cmd.Parameters.AddWithValue("@ph", supplier.Phone);
                cmd.Parameters.AddWithValue("@f", supplier.Fax);
                cmd.Parameters.AddWithValue("@id", supplier.SupplierID);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        #endregion

        #region Employees Function
        public List<Employees> GetEmployeeList()
        {
            List<Employees> employees = new List<Employees>();
            try
            {
                cmd.CommandText = @"SELECT e.EmployeeID, e.FirstName, e.LastName, e.Title, 
            e.Address, e.City, e.PostalCode, e.Country, e.HomePhone FROM Employees e";

                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    employees.Add(new Employees()
                    {
                        EmployeeID = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Title = reader.IsDBNull(3) ? null : reader.GetString(3),
                        Address = reader.IsDBNull(4) ? null : reader.GetString(4),
                        City = reader.IsDBNull(5) ? null : reader.GetString(5),
                        PostalCode = reader.IsDBNull(6) ? null : reader.GetString(6),
                        Country = reader.IsDBNull(7) ? null : reader.GetString(7),
                        HomePhone = reader.IsDBNull(8) ? null : reader.GetString(8)
                    });
                }
            }
            finally
            {
                con.Close();
            }
            return employees;
        }

        public bool AddEmployee(Employees employee)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Employees (FirstName, LastName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, PostalCode, Country, HomePhone, Extension, Notes, Username, Password) VALUES (@fn, @ln, @t, @toc, @bd, @hd, @addr, @city, @postal, @country, @homePhone, @ext, @notes, @username, @password)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fn", employee.FirstName);
                cmd.Parameters.AddWithValue("@ln", employee.LastName);
                cmd.Parameters.AddWithValue("@t", employee.Title);
                cmd.Parameters.AddWithValue("@toc", employee.TitleOfCourtesy);
                cmd.Parameters.AddWithValue("@bd", employee.BirthDate);
                cmd.Parameters.AddWithValue("@hd", employee.HireDate);
                cmd.Parameters.AddWithValue("@addr", employee.Address);
                cmd.Parameters.AddWithValue("@city", employee.City);
                cmd.Parameters.AddWithValue("@postal", employee.PostalCode);
                cmd.Parameters.AddWithValue("@country", employee.Country);
                cmd.Parameters.AddWithValue("@homePhone", employee.HomePhone);
                cmd.Parameters.AddWithValue("@ext", employee.Extension);
                cmd.Parameters.AddWithValue("@notes", employee.Notes);
                cmd.Parameters.AddWithValue("@username", employee.Username);
                cmd.Parameters.AddWithValue("@password", employee.Password);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public Employees GetEmployee(int id)
        {
            try
            {
                Employees employee = new Employees();
                cmd.CommandText = "SELECT EmployeeID, FirstName, LastName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, PostalCode, Country, HomePhone, Extension, Notes, Username FROM Employees WHERE EmployeeID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    employee.EmployeeID = reader.GetInt32(0);
                    employee.FirstName = reader.GetString(1);
                    employee.LastName = reader.GetString(2);
                    employee.Title = reader.GetString(3);
                    employee.TitleOfCourtesy = reader.IsDBNull(4) ? null : reader.GetString(4);
                    employee.BirthDate = reader.GetDateTime(5);
                    employee.HireDate = reader.GetDateTime(6);
                    employee.Address = reader.GetString(7);
                    employee.City = reader.GetString(8);
                    employee.PostalCode = reader.IsDBNull(9) ? null : reader.GetString(9);
                    employee.Country = reader.GetString(10);
                    employee.HomePhone = reader.IsDBNull(11) ? null : reader.GetString(11);
                    employee.Extension = reader.IsDBNull(12) ? null : reader.GetString(12);
                    employee.Notes = reader.IsDBNull(13) ? null : reader.GetString(13);
                    employee.Username = reader.GetString(14);
                }
                return employee;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public void DeleteEmployee(int id)
        {
            try
            {
                cmd.CommandText = "DELETE FROM Employees WHERE EmployeeID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public bool UpdateEmployee(Employees employee)
        {
            try
            {
                cmd.CommandText = "UPDATE Employees SET FirstName=@fn, LastName=@ln, Title=@t, TitleOfCourtesy=@toc, BirthDate=@bd, HireDate=@hd, Address=@addr, City=@city, PostalCode=@postal, Country=@country, HomePhone=@homePhone, Extension=@ext, Notes=@notes, Username=@username, Password=@password WHERE EmployeeID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fn", employee.FirstName);
                cmd.Parameters.AddWithValue("@ln", employee.LastName);
                cmd.Parameters.AddWithValue("@t", employee.Title);
                cmd.Parameters.AddWithValue("@toc", employee.TitleOfCourtesy);
                cmd.Parameters.AddWithValue("@bd", employee.BirthDate);
                cmd.Parameters.AddWithValue("@hd", employee.HireDate);
                cmd.Parameters.AddWithValue("@addr", employee.Address);
                cmd.Parameters.AddWithValue("@city", employee.City);
                cmd.Parameters.AddWithValue("@postal", employee.PostalCode);
                cmd.Parameters.AddWithValue("@country", employee.Country);
                cmd.Parameters.AddWithValue("@homePhone", employee.HomePhone);
                cmd.Parameters.AddWithValue("@ext", employee.Extension);
                cmd.Parameters.AddWithValue("@notes", employee.Notes);
                cmd.Parameters.AddWithValue("@username", employee.Username);
                cmd.Parameters.AddWithValue("@password", employee.Password);
                cmd.Parameters.AddWithValue("@id", employee.EmployeeID);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region Customer Function

        public List<Customer> GetCustomerList()
        {
            List<Customer> customers = new List<Customer>();
            try
            {
                cmd.CommandText = @"SELECT CustomerID, CompanyName, ContactName, ContactTitle, 
                            Address, City, PostalCode, Country, Phone, Fax 
                            FROM Customers";

                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    customers.Add(new Customer()
                    {
                        CustomerID = reader.GetString(0),
                        CompanyName = reader.GetString(1),
                        ContactName = reader.IsDBNull(2) ? null : reader.GetString(2),
                        ContactTitle = reader.IsDBNull(3) ? null : reader.GetString(3),
                        Address = reader.IsDBNull(4) ? null : reader.GetString(4),
                        City = reader.IsDBNull(5) ? null : reader.GetString(5),
                        PostalCode = reader.IsDBNull(6) ? null : reader.GetString(6),
                        Country = reader.IsDBNull(7) ? null : reader.GetString(7),
                        Phone = reader.IsDBNull(8) ? null : reader.GetString(8),
                        Fax = reader.IsDBNull(9) ? null : reader.GetString(9)
                    });
                }
            }
            finally
            {
                con.Close();
            }
            return customers;
        }

        public bool AddCustomer(Customer customer)
        {
            if (GetCustomer(customer.CustomerID) != null)
            {
                MessageBox.Show("Bu CustomerID zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                cmd.CommandText = "INSERT INTO Customers (CustomerID, CompanyName, ContactName, ContactTitle, Address, City, PostalCode, Country, Phone, Fax) VALUES (@id, @cn, @cnm, @ct, @a, @c, @pc, @co, @ph, @f)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", customer.CustomerID);
                cmd.Parameters.AddWithValue("@cn", customer.CompanyName);
                cmd.Parameters.AddWithValue("@cnm", customer.ContactName);
                cmd.Parameters.AddWithValue("@ct", customer.ContactTitle);
                cmd.Parameters.AddWithValue("@a", customer.Address);
                cmd.Parameters.AddWithValue("@c", customer.City);
                cmd.Parameters.AddWithValue("@pc", customer.PostalCode);
                cmd.Parameters.AddWithValue("@co", customer.Country);
                cmd.Parameters.AddWithValue("@ph", customer.Phone);
                cmd.Parameters.AddWithValue("@f", customer.Fax);

                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public Customer GetCustomer(string id)
        {
            try
            {
                Customer customer = new Customer ();
                cmd.CommandText = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, PostalCode, Country, Phone, Fax FROM Customers WHERE CustomerID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    customer = new Customer()
                    {
                        CustomerID = reader.GetString(0),
                        CompanyName = reader.GetString(1),
                        ContactName = reader.IsDBNull(2) ? null : reader.GetString(2),
                        ContactTitle = reader.IsDBNull(3) ? null : reader.GetString(3),
                        Address = reader.IsDBNull(4) ? null : reader.GetString(4),
                        City = reader.IsDBNull(5) ? null : reader.GetString(5),
                        PostalCode = reader.IsDBNull(6) ? null : reader.GetString(6),
                        Country = reader.IsDBNull(7) ? null : reader.GetString(7),
                        Phone = reader.IsDBNull(8) ? null : reader.GetString(8),
                        Fax = reader.IsDBNull(9) ? null : reader.GetString(9)
                    };
                }
                return customer;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public void DeleteCustomer(string id)
        {
            try
            {
                cmd.CommandText = "DELETE FROM Customers WHERE CustomerID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                cmd.CommandText = "UPDATE Customers SET CompanyName=@cn, ContactName=@cnm, ContactTitle=@ct, Address=@a, City=@c, PostalCode=@pc, Country=@co, Phone=@ph, Fax=@f WHERE CustomerID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cn", customer.CompanyName);
                cmd.Parameters.AddWithValue("@cnm", customer.ContactName);
                cmd.Parameters.AddWithValue("@ct", customer.ContactTitle);
                cmd.Parameters.AddWithValue("@a", customer.Address);
                cmd.Parameters.AddWithValue("@c", customer.City);
                cmd.Parameters.AddWithValue("@pc", customer.PostalCode);
                cmd.Parameters.AddWithValue("@co", customer.Country);
                cmd.Parameters.AddWithValue("@ph", customer.Phone);
                cmd.Parameters.AddWithValue("@f", customer.Fax);
                cmd.Parameters.AddWithValue("@id", customer.CustomerID);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        #endregion
    }
}
