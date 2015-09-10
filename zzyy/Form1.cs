

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
//using System.Linq;
//using System.Threading.Tasks;
using System.Text;

using System.Windows.Forms;
using zzyy.Db;

namespace zzyy
{
    public partial class Form1 : Form
    {
        string sql,strFilter;
        private DataTable table;
        DataView dv;
        string hd_patientId,hd_admissTimes;
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            string order_sn = null;
            dr = MessageBox.Show("是否删除", "标题", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                //MessageBox.Show("是");
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value != null)
                    {
                        order_sn = order_sn + dataGridView1.Rows[i].Cells["order_sn"].Value + ",";
                    }
                }
                sql = string.Format("delete from cisdb_yyy.dbo.general_order where order_sn in ({0})",order_sn.Substring(0,order_sn.Length-1));
                DbUtility db = new DbUtility(DbProviderType.SqlServer);
                if (db.ExecuteNonQuery(sql, null) > 0)
                {
                    MessageBox.Show("删除成功！");
                    dataGridView1.DataSource = DbHelper.getOrderByPatientId(hd_patientId, tb_admissTimes.Text);
                    rb_all.Checked = true;
                }
                   
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection =
               new SqlConnection("user id=jhemr;password=jiahemk;initial catalog=chisdb_yyy;Server=192.168.151.108"))
            {
                SqlDataAdapter dataAdpater = new SqlDataAdapter(
                  string.Format(
                        "SELECT g.order_sn,g.display_name,g.long_once_flag,g.effective_time_b,g.order_status,g.doc_note " +
  "FROM cisdb_yyy.dbo.general_order g WHERE enc_id = (" +
    "SELECT pe.patient_encounter_id" +
     " FROM cisdb_yyy.dbo.patient_encounter pe WHERE pe.patient_id='{0}' and pe.in_visit_times = {1}) order by long_once_flag, effective_time_b ", hd_patientId, tb_admissTimes.Text),
                  connection);

                dataAdpater.UpdateCommand = new SqlCommand(
                   "UPDATE cisdb_yyy.dbo.general_order SET effective_time_b = @CategoryName,stop_time=@stop_time " +
                   "WHERE order_sn = @CategoryID", connection);

                dataAdpater.UpdateCommand.Parameters.Add(
                   "@CategoryName", SqlDbType.DateTime, 15, "effective_time_b");
                dataAdpater.UpdateCommand.Parameters.Add(
                   "@stop_time", SqlDbType.DateTime, 15, "stop_time");
                SqlParameter parameter = dataAdpater.UpdateCommand.Parameters.Add(
                  "@CategoryID", SqlDbType.Char);
                parameter.SourceColumn = "order_sn";
                parameter.SourceVersion = DataRowVersion.Original;

                //DataTable categoryTable = new DataTable();
                //dataAdpater.Fill(categoryTable);

                //DataRow categoryRow = categoryTable.Rows[0];
                //categoryRow["CategoryName"] = "New Beverages";

               DataTable table2;

                if (dataGridView1.DataSource.GetType() == typeof(DataView))
                    table2 = ((DataView)dataGridView1.DataSource).Table;
                else
                    table2 = (DataTable)dataGridView1.DataSource;
                if (dataAdpater.Update(table2) > 0)
                {
                    MessageBox.Show("修改成功！");
                    getPatientOrder(dataGridView1);
                    rb_all.Checked = true;
                }
                

                
            }

        }

        private void 费用删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delFee fee = new delFee();
            //fee.WindowState = FormWindowState.Maximized;
            fee.Show();
        }

        private void 医嘱修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patient patient = new patient();
            patient.Show();
        }

        private void getPatientOrder(DataGridView dgv)
        {
            table = DbHelper.getPatInfoByInpNo(txt_inpNo.Text, tb_admissTimes.Text);
            if (table.Rows.Count > 0)
            {
                lbl_val_name.Text = (string)table.Rows[0]["name"];
                lbl_val_bedNo.Text = (string)table.Rows[0]["bed_no"];
                hd_patientId = (string)table.Rows[0]["patient_id"];
                hd_admissTimes = tb_admissTimes.Text;
                table = DbHelper.getOrderByPatientId(hd_patientId, tb_admissTimes.Text);

                dgv.Columns["order_sn"].DataPropertyName = "order_sn";
                dgv.Columns["order_name"].DataPropertyName = "display_name";
                dgv.Columns["long_once_flag"].DataPropertyName = "long_once_flag";
                dgv.Columns["effective_time_b"].DataPropertyName = "effective_time_b";
                dgv.Columns["stop_time"].DataPropertyName = "stop_time";
                dgv.Columns["order_status"].DataPropertyName = "order_status";
                dgv.Columns["doc_note"].DataPropertyName = "doc_note";
                dgv.DataSource = table;

                btn_clearOrderPrint.Enabled = true;
            }
            else
            {
                table.Rows.Clear();
                dgv.DataSource = table;
                MessageBox.Show("没有此病人信息");
            }
        
        }


        private void btn_qry_Click(object sender, EventArgs e)
        {
            if (txt_inpNo.Text.Trim() == "")
            {
                MessageBox.Show("住院号不能为空！");
                return;
            }
             getPatientOrder(dataGridView1);
            

            //dataGridView1.Columns["order_sn"].DataPropertyName = "order_sn"; 
            //MessageBox.Show("回车");
        }

      

       

        private void rb_all_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_all.Checked == true)
                dataGridView1.DataSource = table;
            if (rb_long.Checked == true)
            {
                if (table != null &&  table.Rows.Count > 0)
                {
                    dv = table.Copy().DefaultView;
                    dv.RowFilter = "long_once_flag=1";
                    dataGridView1.DataSource = dv;
                }
   
            }
            if (rb_once.Checked == true)
            {
                    if (table != null && table.Rows.Count > 0)
                    {
                        dv = table.Copy().DefaultView;
                        dv.RowFilter = "long_once_flag=0";
                        dataGridView1.DataSource = dv;
                    }
  
            }
            

            
        }

        private void rb_long_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_all.Checked == true)
                dataGridView1.DataSource = table;
            if (rb_long.Checked == true)
            {
                if (table != null && table.Rows.Count > 0)
                {
                    dv = table.Copy().DefaultView;
                    dv.RowFilter = "long_once_flag=1";
                    dataGridView1.DataSource = dv;
                }

            }
            if (rb_once.Checked == true)
            {
                if (table != null && table.Rows.Count > 0)
                {
                    dv = table.Copy().DefaultView;
                    dv.RowFilter = "long_once_flag=0";
                    dataGridView1.DataSource = dv;
                }

            }
            //if (rb_all.Checked == true)
            //    dataGridView1.DataSource = table;
            //if (rb_long.Checked == true)
            //{
            //    dv = table.Copy();
            //    dv.Select("long_once_flag=1");
            //    dataGridView1.DataSource = dv;
            //}
            //if (rb_once.Checked == true)
            //{
            //    dv = table.Copy();
            //    dv = dv.Select("long_once_flag=0");
            //    dataGridView1.DataSource = dv;
            //}
        }

        private void rb_once_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_all.Checked == true)
                dataGridView1.DataSource = table;
            if (rb_long.Checked == true)
            {
                if (table != null && table.Rows.Count > 0)
                {
                    dv = table.Copy().DefaultView;
                    dv.RowFilter = "long_once_flag=1";
                    dataGridView1.DataSource = dv;
                }

            }
            if (rb_once.Checked == true)
            {
                if (table != null && table.Rows.Count > 0)
                {
                    dv = table.Copy().DefaultView;
                    dv.RowFilter = "long_once_flag=0";
                    dataGridView1.DataSource = dv;
                }

            }
        }

        private void btn_clearOrderPrint_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            string temp ="" ;
            int longOnce = 2;
            if (rb_all.Checked == true)
            {
                MessageBox.Show("请选择医嘱类型！");
                return;
            }
               
            if (rb_long.Checked == true)
            {
                temp = rb_long.Text;
                longOnce = 1;
            }

            if (rb_once.Checked == true)
            {
                temp = rb_once.Text;
                longOnce = 0;
            }

            dr = MessageBox.Show("是否删除已打印的"+temp, "标题", MessageBoxButtons.OKCancel);
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                if (DbHelper.clearOrderPrintByPatientId(hd_patientId, hd_admissTimes, longOnce)>0)
                    MessageBox.Show("已打印医嘱清空成功!");
                else
                    MessageBox.Show("没有需要清空的医嘱!");
            }
        }


    }
}
