using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StockCounter
{
    public partial class Form1 : Form
    {
        SqlConnection newcnn = new SqlConnection(Properties.Settings.Default.newcnn);

        public Form1()
        {
            InitializeComponent();
        }
        //all button functions when they are clicked
        private void btn_save_Click(object sender, EventArgs e)
        {
            //inserting a new row with given information
            try
            {
                SaveData();
                this.correctMainTableAdapter.FillAll(this.newcnnData.CorrectMain);
                this.leverancierBETableAdapter.FillLeverancier(this.newcnnData.LeverancierBE);
                this.typesBETableAdapter.FillTypes(this.newcnnData.TypesBE);
            }
            //For if barcode already exists
            catch (SqlException ex)
            {
                // Log the exception details
                MessageBox.Show($"SQL Exception: {ex.Message}", "Error");

                // Check inner exception
                if (ex.InnerException != null)
                {
                    MessageBox.Show($"Inner Exception: {ex.InnerException.Message}", "Inner Exception");
                }
            }
            catch (Exception ex)
            {
                // Log the exception details
                MessageBox.Show($"An error occurred while saving data: {ex.Message}", "Error");

                // Check inner exception
                if (ex.InnerException != null)
                {
                    MessageBox.Show($"Inner Exception: {ex.InnerException.Message}", "Inner Exception");
                }

                // Additional debugging information
                MessageBox.Show($"Stack Trace: {ex.StackTrace}", "Debugging Info");
            }
            finally
            {
                newcnn.Close();
            }
        }
        private void btn_connect_Click(object sender, EventArgs e)
        {
            //testing the connection
            try
            {
                newcnn.Open();
                lblIfConnected.BackColor = System.Drawing.Color.Green;
                lblIfConnected.ForeColor = System.Drawing.Color.White;
                lblIfConnected.Text = "Connection Success";
            }
            //catch is failed and make the status label an other color
            catch (Exception)
            {
                lblIfConnected.BackColor = System.Drawing.Color.Red;
                lblIfConnected.ForeColor = System.Drawing.Color.White;
                lblIfConnected.Text = "Connection failed!";
            }
            //always close connection, it lowers the chance of corrupted databases
            finally
            {
                newcnn.Close();
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            //updating an already existing row wich has been selected by the user
            try
            {
                int Stock = Convert.ToInt32(Math.Round(amnt_prod.Value, 0));
                UpdateData(bar_prod.Text, name_prod.Text, hulpnr_prod.Text, Stock, lever_prod.Text, type_prod.Text);
                this.correctMainTableAdapter.FillAll(this.newcnnData.CorrectMain);
                this.leverancierBETableAdapter.FillLeverancier(this.newcnnData.LeverancierBE);
                this.typesBETableAdapter.FillTypes(this.newcnnData.TypesBE);
            }
            //for if something went wrong or the connection didnt close properly
            catch (SqlException ex)
            {
                // Log the exception details
                MessageBox.Show($"SQL Exception: {ex.Message}", "Error");

                // Check inner exception
                if (ex.InnerException != null)
                {
                    MessageBox.Show($"Inner Exception: {ex.InnerException.Message}", "Inner Exception");
                }
            }
            catch (Exception ex)
            {
                // Log the exception details
                MessageBox.Show($"An error occurred while updating data: {ex.Message}", "Error");

                // Check inner exception
                if (ex.InnerException != null)
                {
                    MessageBox.Show($"Inner Exception: {ex.InnerException.Message}", "Inner Exception");
                }

                // Additional debugging information
                MessageBox.Show($"Stack Trace: {ex.StackTrace}", "Debugging Info");
            }
            //always close connection
            finally
            {
                newcnn.Close();
            }
        }
        private void btn_remove_one_Click(object sender, EventArgs e)
        {
            // Close connection if somehow still open to remove chances of corruption
            newcnn.Close();

            // Making a dialog result type variable
            DialogResult answer;

            // Putting the result into variable
            answer = MessageBox.Show("You are about to remove 1 item from stock.\nDo you want to continue?", "WARNING!", MessageBoxButtons.OKCancel);

            // Check what the user input is and respond correspondingly
            if (answer == DialogResult.OK)
            {
                try
                {
                    using (var db = new ProductDataContext(Properties.Settings.Default.newcnn))
                    {
                        // Retrieve the product by barcode
                        var product = db.Products.SingleOrDefault(p => p.Barcode == bar_prod.Text);

                        if (product != null)
                        {
                            // Ensure the stock count is greater than 0 before decrementing
                            if (product.StockCount > 0)
                            {
                                product.StockCount--;

                                // Submit changes to the database
                                db.SubmitChanges();
                                MessageBox.Show("Removal successful!");
                                this.correctMainTableAdapter.FillAll(this.newcnnData.CorrectMain);
                                this.leverancierBETableAdapter.FillLeverancier(this.newcnnData.LeverancierBE);
                                this.typesBETableAdapter.FillTypes(this.newcnnData.TypesBE);
                            }
                            else
                            {
                                MessageBox.Show("Stock count is already at the minimum value (0).");
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Product with barcode {bar_prod.Text} not found.", "Error");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log the exception details
                    MessageBox.Show($"An error occurred while removing 1 out of stock: {ex.Message}", "Error");

                    // Check inner exception
                    if (ex.InnerException != null)
                    {
                        MessageBox.Show($"Inner Exception: {ex.InnerException.Message}", "Inner Exception");
                    }

                    // Additional debugging information
                    MessageBox.Show($"Stack Trace: {ex.StackTrace}", "Debugging Info");
                }
                finally
                {
                    // Always close connection
                    newcnn.Close();
                }
            }
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            //putting the datatable inside the existing grid
            try
            {
                //dataGridView1.DataSource = productBEBindingSource;
                this.correctMainTableAdapter.FillAll(this.newcnnData.CorrectMain);
                this.leverancierBETableAdapter.FillLeverancier(this.newcnnData.LeverancierBE);
                this.typesBETableAdapter.FillTypes(this.newcnnData.TypesBE);
            }
            //catching any error if there is any
            catch (System.Exception)
            {
                MessageBox.Show("It seems the connection is not set up proparly, Try again");
            }
            //always close the connection again and again... ive read this before, am i going crazy??
            finally
            {
                newcnn.Close();
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //close connection if somehow still open to remove chances of corruption
            newcnn.Close();
            //making a dialogresult type variable
            DialogResult answer;
            //putting the result into variable
            answer = MessageBox.Show("You are about to delete this product from the database.\nDo you want to continue?", "WARNING!", MessageBoxButtons.OKCancel);
            //check what the user input is and respond correspondingly
            if (answer == DialogResult.OK)
            {
                //delete a full row which has been selected by the user
                try
                {
                    DeleteData(bar_prod.Text);
                    //this.productBETableAdapter.FillProduct(this.newcnnData.ProductBE);
                    this.correctMainTableAdapter.FillAll(this.newcnnData.CorrectMain);
                    this.leverancierBETableAdapter.FillLeverancier(this.newcnnData.LeverancierBE);
                    this.typesBETableAdapter.FillTypes(this.newcnnData.TypesBE);
                }
                //for if anything failed
                catch (Exception ex)
                {
                    // Log the exception details
                    MessageBox.Show($"An error occurred while deleting data: {ex.Message}", "Error");

                    // Check inner exception
                    if (ex.InnerException != null)
                    {
                        MessageBox.Show($"Inner Exception: {ex.InnerException.Message}", "Inner Exception");
                    }

                    // Additional debugging information
                    MessageBox.Show($"Stack Trace: {ex.StackTrace}", "Debugging Info");
                }
                //again and again, always close connection
                finally
                {
                    newcnn.Close();
                }
            }
        }
        private void btn_check_low_Click(object sender, EventArgs e)
        {
            //putting the datatable inside the existing grid
            try
            {
                dataGridView1.DataSource = GetDataLowStock();
            }
            //catching any error if there is any
            catch (System.Exception)
            {
                MessageBox.Show("It seems the connection is not set up proparly, Try again");
            }
            //always close the connection again and again... ive read this before, am i going crazy??
            finally
            {
                newcnn.Close();
            }
        }
        private void btn_delType_Click(object sender, EventArgs e)
        {
            try
            {
                // Call the DeleteTypeByName function with the type name from type_prod.Text
                DeleteTypeByName(type_prod.Text);
                this.typesBETableAdapter.FillTypes(this.newcnnData.TypesBE);
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                // Handle SQL exceptions
                MessageBox.Show($"SQL Exception: {sqlEx.Message}");

                // Check inner exception
                if (sqlEx.InnerException != null)
                {
                    MessageBox.Show($"Inner Exception: {sqlEx.InnerException.Message}");
                }
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show($"An error occurred: {ex.Message}");

                // Check inner exception
                if (ex.InnerException != null)
                {
                    MessageBox.Show($"Inner Exception: {ex.InnerException.Message}");
                }
            }
        }
        private void btn_delLev_Click(object sender, EventArgs e)
        {
            try
            {
                // Call the DeleteLeverancierByName function with the leverancier name from leverancier_prod.Text
                DeleteLeverancierByName(lever_prod.Text);
                this.leverancierBETableAdapter.FillLeverancier(this.newcnnData.LeverancierBE);
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                // Handle SQL exceptions
                MessageBox.Show($"SQL Exception: {sqlEx.Message}");

                // Check inner exception
                if (sqlEx.InnerException != null)
                {
                    MessageBox.Show($"Inner Exception: {sqlEx.InnerException.Message}");
                }
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show($"An error occurred: {ex.Message}");

                // Check inner exception
                if (ex.InnerException != null)
                {
                    MessageBox.Show($"Inner Exception: {ex.InnerException.Message}");
                }
            }
        }



        //self made functions
            //voids
        private void SaveData()
        {
            using (var db = new ProductDataContext(Properties.Settings.Default.newcnn))
            {
                // Check if LeverancierC exists or add it
                var leverancier = db.Leveranciers.SingleOrDefault(l => l.Leverancier == lever_prod.Text);
                if (leverancier == null)
                {
                    leverancier = new LeverancierC { Leverancier = lever_prod.Text };
                    db.Leveranciers.InsertOnSubmit(leverancier);
                    db.SubmitChanges(); // Save changes to ensure the new LeverancierC is added
                }

                // Check if Types exists or add it
                var type = db.Types.SingleOrDefault(t => t.Type == type_prod.Text);
                if (type == null)
                {
                    type = new Types { Type = type_prod.Text };
                    db.Types.InsertOnSubmit(type);
                    db.SubmitChanges(); // Save changes to ensure the new Type is added
                }

                // Create a new Product entity
                var newProduct = new Product
                {
                    Barcode = bar_prod.Text,
                    Name = name_prod.Text,
                    Hulpnummer = hulpnr_prod.Text,
                    StockCount = Convert.ToInt32(Math.Round(amnt_prod.Value, 0)),
                    LeverancierC = leverancier,
                    Types = type,
                    LeverancierID = leverancier.LeverancierID, // Set the foreign key explicitly
                    TypeID = type.TypeID // Set the foreign key explicitly
                };

                // Add the new Product entity to the Products table
                db.Products.InsertOnSubmit(newProduct);

                // Submit changes to the database
                db.SubmitChanges();
            }
        }
        private void UpdateData(string barcodeToUpdate, string newProductName, string newHulpnummer, int newStockCount, string newLeverancier, string newType)
        {
            using (var db = new ProductDataContext(Properties.Settings.Default.newcnn))
            {
                // Find the existing product by barcode
                var existingProduct = db.Products.SingleOrDefault(p => p.Barcode == barcodeToUpdate);

                if (existingProduct != null)
                {
                    // Check if the LeverancierC exists or add it
                    var leverancier = db.Leveranciers.SingleOrDefault(l => l.Leverancier == newLeverancier);
                    if (leverancier == null)
                    {
                        leverancier = new LeverancierC { Leverancier = newLeverancier };
                        db.Leveranciers.InsertOnSubmit(leverancier);
                        db.SubmitChanges(); // Save changes to ensure the new LeverancierC is added
                    }

                    // Check if the Types exists or add it
                    var type = db.Types.SingleOrDefault(t => t.Type == newType);
                    if (type == null)
                    {
                        type = new Types { Type = newType };
                        db.Types.InsertOnSubmit(type);
                        db.SubmitChanges(); // Save changes to ensure the new Type is added
                    }

                    // Update the existing product
                    existingProduct.Name = newProductName;
                    existingProduct.Hulpnummer = newHulpnummer;
                    existingProduct.StockCount = newStockCount;
                    existingProduct.LeverancierC = leverancier;
                    existingProduct.Types = type;
                    existingProduct.LeverancierID = leverancier.LeverancierID; // Set the foreign key explicitly
                    existingProduct.TypeID = type.TypeID; // Set the foreign key explicitly

                    // Submit changes to the database
                    db.SubmitChanges();
                }
                else
                {
                    // Handle case where the product with the given barcode doesn't exist
                    MessageBox.Show($"Product with barcode {barcodeToUpdate} not found.", "Error");
                }
            }
        }
        private void DeleteData(string barcodeToDelete)
        {
            using (var db = new ProductDataContext(Properties.Settings.Default.newcnn))
            {
                // Find the existing product by barcode
                var productToDelete = db.Products.SingleOrDefault(p => p.Barcode == barcodeToDelete);

                if (productToDelete != null)
                {
                    // Remove the product from the Products table
                    db.Products.DeleteOnSubmit(productToDelete);

                    // Submit changes to the database
                    db.SubmitChanges();
                }
                else
                {
                    // Handle case where the product with the given barcode doesn't exist
                    MessageBox.Show($"Product with barcode {barcodeToDelete} not found.", "Error");
                }
            }
        }
        private void DeleteTypeByName(string typeNameToDelete)
        {
            using (var db = new ProductDataContext(Properties.Settings.Default.newcnn))
            {
                // Retrieve the type by name
                var typeToDelete = db.Types.SingleOrDefault(t => t.Type == typeNameToDelete);

                if (typeToDelete != null)
                {
                    // Check if the type is used by any products
                    var productsWithSameType = db.Products.Where(p => p.TypeID == typeToDelete.TypeID).ToList();

                    if (productsWithSameType.Count == 0)
                    {
                        // If the type is not used by any products, remove it from the TypesBE table
                        db.Types.DeleteOnSubmit(typeToDelete);

                        // Submit changes to the database
                        db.SubmitChanges();
                    }
                    else
                    {
                        MessageBox.Show($"Cannot delete type '{typeNameToDelete}' because it is associated with one or more products.", "Error");
                    }
                }
                else
                {
                    MessageBox.Show($"Type '{typeNameToDelete}' not found.", "Error");
                }
            }
        }
        private void DeleteLeverancierByName(string leverancierNameToDelete)
        {
            using (var db = new ProductDataContext(Properties.Settings.Default.newcnn))
            {
                // Retrieve the leverancier by name
                var leverancierToDelete = db.Leveranciers.SingleOrDefault(l => l.Leverancier == leverancierNameToDelete);

                if (leverancierToDelete != null)
                {
                    // Check if the leverancier is used by any products
                    var productsWithSameLeverancier = db.Products.Where(p => p.LeverancierID == leverancierToDelete.LeverancierID).ToList();

                    if (productsWithSameLeverancier.Count == 0)
                    {
                        // If the leverancier is not used by any products, remove it from the LeverancierBE table
                        db.Leveranciers.DeleteOnSubmit(leverancierToDelete);

                        // Submit changes to the database
                        db.SubmitChanges();
                    }
                    else
                    {
                        MessageBox.Show($"Cannot delete leverancier '{leverancierNameToDelete}' because it is associated with one or more products.", "Error");
                    }
                }
                else
                {
                    MessageBox.Show($"Leverancier '{leverancierNameToDelete}' not found.", "Error");
                }
            }
        }
            //dataTables
        public DataTable GetDataLowStock()
        {
            using (var db = new ProductDataContext(Properties.Settings.Default.newcnn))
            {
                // LINQ to SQL query to retrieve products with StockCount between 0 and 2
                var lowStockProducts = from product in db.Products
                                       where product.StockCount >= 0 && product.StockCount <= checkstock_prod.Value
                                       select product;

                // Convert the LINQ query result to a DataTable
                DataTable dt = new DataTable();
                dt.Columns.Add("Barcode");
                dt.Columns.Add("Name");
                dt.Columns.Add("Hulpnummer");
                dt.Columns.Add("StockCount");

                foreach (var product in lowStockProducts)
                {
                    dt.Rows.Add(product.Barcode, product.Name, product.Hulpnummer, product.StockCount);
                }

                return dt;
            }
        }


        //accidentally double clicked and too lazy to delete.
        private void name_prod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lblIfConnected_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newcnnData.CorrectMain' table. You can move, or remove it, as needed.
            this.correctMainTableAdapter.FillAll(this.newcnnData.CorrectMain);
            // TODO: This line of code loads data into the 'newcnnData.TypesBE' table. You can move, or remove it, as needed.
            this.typesBETableAdapter.FillTypes(this.newcnnData.TypesBE);
            // TODO: This line of code loads data into the 'newcnnData.LeverancierBE' table. You can move, or remove it, as needed.
            this.leverancierBETableAdapter.FillLeverancier(this.newcnnData.LeverancierBE);
            // TODO: This line of code loads data into the 'newcnnData.ProductBE' table. You can move, or remove it, as needed.
            this.productBETableAdapter.FillProduct(this.newcnnData.ProductBE);

        }
        private void amnt_prod_ValueChanged(object sender, EventArgs e)
        {

        }
        private void bar_prod_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            //if (e.Equals("{ENTER}"))
            //{
            //    dataGridView1.DataSource = GetDataRequested();
            //}
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

    //context for the database
    public class ProductDataContext : DataContext
    {
        public Table<Product> Products;
        public Table<LeverancierC> Leveranciers;
        public Table<Types> Types;
        
        public ProductDataContext(string connectionString) : base(connectionString) { }
    }
    //table for products
    [Table(Name = "ProductBE")]
    public class Product
    {


        [Column(IsPrimaryKey = true)]
        public string Barcode { get; set; }
        [Column]
        public string Name { get; set; }
        [Column]
        public string Hulpnummer { get; set; }
        [Column]
        public int StockCount { get; set; }

        //foreign keys
        [Column] 
        public int TypeID { get; set; }
        [Column]
        public int LeverancierID { get; set; }

        //navigation?
        public Types Types { get; set; }
        public LeverancierC LeverancierC { get; set; }

    }
    //table for leveranciers
    [Table(Name = "LeverancierBE")]
    public class LeverancierC
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int LeverancierID { get; set; }
        [Column]
        public string Leverancier { get; set; }
    }
    //table for types
    [Table(Name = "TypesBE")]
    public class Types
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int TypeID { get; set; }
        [Column]
        public string Type { get; set; }
    }
}
