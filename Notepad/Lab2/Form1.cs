using Lab2.Models;
using System.Data;

namespace Lab2
{
    public partial class Form1 : Form
    {
        int oldEmID;
        int supOldId;
        string cusOlId;
        DateTime oldODF = DateTime.Now;
        DateTime oldODT = DateTime.Now;
        double oldFrF;
        double oldFRT;
        String sortReq;
        public Form1()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add("OrderId", "OrderId");
            dataGridView1.Columns["OrderId"].DataPropertyName = "OrderId";
            //dataGridView1.Columns.Add("EmployeeId", "EmployeeId");
            //dataGridView1.Columns["EmployeeId"].DataPropertyName = "EmployeeId";
            dataGridView1.Columns.Add("LastName", "LastName");
            dataGridView1.Columns["LastName"].DataPropertyName = "LastName";
            dataGridView1.Columns.Add("FirstName", "FirstName");
            dataGridView1.Columns["FirstName"].DataPropertyName = "FirstName";
            dataGridView1.Columns.Add("CustomerId", "CustomerId");
            dataGridView1.Columns["CustomerId"].DataPropertyName = "CustomerId";
            dataGridView1.Columns.Add("CompanyName", "CompanyName");
            dataGridView1.Columns["CompanyName"].DataPropertyName = "CompanyName";
            dataGridView1.Columns.Add("OrderDate", "OrderDate");
            dataGridView1.Columns["OrderDate"].DataPropertyName = "OrderDate";
            dataGridView1.Columns.Add("Freight", "Freight");
            dataGridView1.Columns["Freight"].DataPropertyName = "Freight";


            DataGridViewButtonColumn editCol = new DataGridViewButtonColumn();
            editCol.Name = "editCol";
            editCol.HeaderText = "Edit";
            editCol.Text = "Edit";
            editCol.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(editCol);
            DataGridViewButtonColumn deleteCol = new DataGridViewButtonColumn();
            deleteCol.Name = "deleteCol";
            deleteCol.HeaderText = "Delete";
            deleteCol.Text = "Delete";
            deleteCol.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deleteCol);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NorthwindContext db = new NorthwindContext();
            var orders = from o in db.Orders
                         join cs in db.Customers on o.CustomerId equals cs.CustomerId
                         join em in db.Employees on o.EmployeeId equals em.EmployeeId
                         select new
                         {
                             o.OrderId,
                             em.LastName,
                             em.FirstName,
                             o.CustomerId,
                             cs.CompanyName,
                             o.OrderDate,
                             o.Freight
                         };
            dataGridView1.DataSource = orders.ToList();

            var employees = from em in db.Employees select em;
            List<Employee> employeesList = employees.ToList();
            DataTable dte = new DataTable();
            dte.Columns.Add("EmployeeId", typeof(int));
            dte.Columns.Add("FullName");
            DataRow dre = dte.NewRow();
            dre["FullName"] = "--All--";
            dre["EmployeeId"] = -1;
            dte.Rows.InsertAt(dre, 0);
            for (int i = 0; i < employeesList.Count; i++)
            {
                DataRow dref = dte.NewRow();
                dref["FullName"] = employeesList.ElementAt(i).FirstName + " " + employeesList.ElementAt(i).LastName;
                dref["EmployeeId"] = employeesList.ElementAt(i).EmployeeId;
                dte.Rows.InsertAt(dref, (i + 1));
            }
            employeeFlt.DataSource = dte;
            employeeFlt.DisplayMember = "FullName";
            employeeFlt.ValueMember = "EmployeeId";
            oldEmID = -1;

            //list sup
            var sups = from sup in db.Suppliers select sup;
            List<Supplier> supplierList = sups.ToList();
            DataTable dts = new DataTable();
            dts.Columns.Add("SupplierId", typeof(int));
            dts.Columns.Add("CompanyName");
            DataRow drs = dts.NewRow();
            drs["CompanyName"] = "--All--";
            drs["SupplierId"] = -1;
            dts.Rows.InsertAt(drs, 0);
            for (int i = 0; i < supplierList.Count; i++)
            {
                DataRow drf = dts.NewRow();
                drf["CompanyName"] = supplierList.ElementAt(i).CompanyName;
                drf["SupplierId"] = supplierList.ElementAt(i).SupplierId;
                dts.Rows.InsertAt(drf, (i + 1));
            }
            supplierFlt.DataSource = dts;
            supplierFlt.DisplayMember = "CompanyName";
            supplierFlt.ValueMember = "SupplierId";
            supOldId = -1;

            var cus = from c in db.Customers select c;
            List<Customer> cusList = cus.ToList();
            DataTable dtcs = new DataTable();
            dtcs.Columns.Add("CustomerId", typeof(string));
            dtcs.Columns.Add("CompanyName");
            DataRow drcs = dtcs.NewRow();
            drcs["CompanyName"] = "--All--";
            drcs["CustomerId"] = "";
            dtcs.Rows.InsertAt(drcs, 0);
            for (int i = 0; i < cusList.Count; i++)
            {
                DataRow drf = dtcs.NewRow();
                drf["CompanyName"] = cusList.ElementAt(i).CompanyName;
                drf["CustomerId"] = cusList.ElementAt(i).CustomerId;
                dtcs.Rows.InsertAt(drf, (i + 1));
            }
            customerFlt.DataSource = dtcs;
            customerFlt.DisplayMember = "CompanyName";
            customerFlt.ValueMember = "CustomerId";
            cusOlId = "";

            var minOrD = (from minod in db.Orders select minod).Min(minod => minod.OrderDate);
            var maxOrD = (from maxod in db.Orders select maxod).Max(maxod => maxod.OrderDate);
            oderDateFrom.Value = Convert.ToDateTime(minOrD);
            oderDateTo.Value = Convert.ToDateTime(maxOrD);
            oldODF = Convert.ToDateTime(minOrD);
            oldODT = Convert.ToDateTime(maxOrD);

            var minFr = (from min in db.Orders select min).Min(min => min.Freight);
            var maxFr = (from max in db.Orders select max).Max(max => max.Freight);
            freightFrom.Value = Convert.ToInt32(minFr);
            freightTo.Value = Convert.ToInt32(maxFr);
            oldFrF = Convert.ToInt32(minFr);
            oldFRT = Convert.ToInt32(maxFr);

        }

        private void oderDateFrom_ValueChanged(object sender, EventArgs e)
        {
            var newMinOrD = oderDateFrom.Value;
        }

        private void employeeFlt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Filter_Click(object sender, EventArgs e)
        {
            int newEmFl = Convert.ToInt32(employeeFlt.SelectedValue.ToString());
            int newSupFl = Convert.ToInt32(supplierFlt.SelectedValue.ToString());
            string newCusFl = customerFlt.SelectedValue.ToString();
            DateTime newDateFrom = oderDateFrom.Value;
            DateTime newDateTo = oderDateTo.Value;
            int newFrF = Convert.ToInt32(freightFrom.Value.ToString());
            int newFrT = Convert.ToInt32(freightTo.Value.ToString());

            int compareDF = DateTime.Compare(newDateFrom, oldODF);
            int compareDT = DateTime.Compare(newDateTo, oldODT);

            if (compareDF < 0 || compareDT > 0 || oldFrF > newFrF || oldFRT < newFrT)
            {
                MessageBox.Show("Value of new From can't be less than old From\n" +
                    "And Value of new To can't be greater than old To");
                oderDateFrom.Value = oldODF;
                oderDateTo.Value = oldODT;
                freightFrom.Value = Convert.ToInt32(oldFrF);
                freightTo.Value = Convert.ToInt32(oldFRT);
            }

            string sortby = "";
            bool isE = sortByEmployee.Checked;
            if (isE)
                sortby = sortByEmployee.Text;

            bool isC = sortByCustomer.Checked;
            if (isC)
                sortby = sortByCustomer.Text;

            bool isOD = sortByOderDate.Checked;
            if (isOD)
                sortby = sortByOderDate.Text;

            NorthwindContext db = new NorthwindContext();
            var orders = from or in db.Orders
                         join cus in db.Customers on or.CustomerId equals cus.CustomerId
                         join em in db.Employees on or.EmployeeId equals em.EmployeeId
                         join ord in db.OrderDetails on or.OrderId equals ord.OrderId
                         join pro in db.Products on ord.ProductId equals pro.ProductId
                         join sup in db.Suppliers on pro.SupplierId equals sup.SupplierId
                         select new
                         {
                             or.OrderId,
                             or.CustomerId,
                             cus.CompanyName,
                             or.EmployeeId,
                             em.LastName,
                             em.FirstName,
                             or.OrderDate,
                             or.Freight,
                             sup.SupplierId,
                             Supplier_Name = sup.CompanyName
                         };
            if (newEmFl != -1)
            {
                orders = orders.Where(or => or.EmployeeId == newEmFl);
            }
            if (newSupFl != -1)
            {
                orders = orders.Where(or => or.SupplierId == newSupFl);
            }
            if (newCusFl.Length != 0)
            {
                orders = orders.Where(or => or.CustomerId.Equals(newCusFl));
            }
            if (compareDF >= 0)
            {
                orders = orders.Where(or => or.OrderDate >= newDateFrom);
            }
            if (compareDT <= 0)
            {
                orders = orders.Where(or => or.OrderDate <= newDateTo);
            }
            if (oldFrF <= newFrF)
            {
                orders = orders.Where(or => or.Freight >= newFrF);
            }
            if (oldFRT >= newFrT)
            {
                orders = orders.Where(or => or.Freight <= newFrT);
            }
            if (sortby.Equals("By Employee"))
            {
                orders = orders.OrderBy(or => or.LastName).ThenBy(or => or.FirstName);
            }
            if (sortby.Equals("By Customer"))
            {
                orders = orders.OrderBy(or => or.CompanyName);
            }
            if (sortby.Equals("By OrderDate"))
            {
                orders = orders.OrderBy(or => or.OrderDate);
            }
            dataGridView1.DataSource = orders.ToList();
        }

        private void freightFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NorthwindContext db = new NorthwindContext();
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("editCol"))
            {
                List<Order> orders = (List<Order>)dataGridView1.DataSource;

            }
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("deleteCol"))
            {
                if (MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var value = dataGridView1.Rows[e.RowIndex].Cells["OrderId"].Value;
                    Order o = db.Orders.Where(x => x.OrderId == Convert.ToUInt32(value)).SingleOrDefault();
                    var od = db.OrderDetails.Where(x => x.OrderId == Convert.ToUInt32(value)).ToList();
                    foreach (OrderDetail ode in od)
                    {
                        db.OrderDetails.Remove(ode);
                    }
                    db.Orders.Remove(o);
                    db.SaveChanges();
                    Form1_Load(sender,e);
                }
            }
        }
    }
}