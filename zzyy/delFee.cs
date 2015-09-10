using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
//using System.Threading.Tasks;
using System.Text;

using System.Windows.Forms;
using zzyy.Db;

namespace zzyy
{
    public partial class delFee : Form
    {
        public delFee()
        {
            InitializeComponent();
        }
        private DataTable patientTable, table; 
        string hd_patientId;
        decimal sumAmount, sumMoney;

        private void txt_inpNo_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                
            }

        }

        private void btn_clearFee_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            //if (sumAmount != 0)
            //    MessageBox.Show("记账总次数>0，不能删除");
            //else
            //{
            //    dr = MessageBox.Show("是否删除", "标题", MessageBoxButtons.OKCancel);
            //    if (dr== DialogResult.OK)
            //    {
            //        if (DbHelper. delFeeByPatientId(hd_patientId, tb_admissTimes.Text, tb_chargeCode.Text) > 0)
            //            MessageBox.Show("删除成功");
            //    }
            //}

            if (DbHelper.delFeeByPatientId(hd_patientId, tb_admissTimes.Text, tb_chargeCode.Text))
            {
                MessageBox.Show("删除成功");
                table.Rows.Clear();
                dataGridView_fee.DataSource = table;
                lb_sumAmount.Text = "0";
                lb_sumMoney.Text = "0";
            }
                        
        }

        private void btn_qry_Click(object sender, EventArgs e)
        {
            if (txt_inpNo.Text.Trim() == "" || tb_admissTimes.Text == "" || tb_chargeCode.Text == "")
            {
                MessageBox.Show("不能为空");
                return;
            }
            patientTable = DbHelper.getPatInfoByInpNo(txt_inpNo.Text, tb_admissTimes.Text);
            if (patientTable.Rows.Count > 0)
            {
                lbl_val_name.Text = (string)patientTable.Rows[0]["name"];
                lbl_val_bedNo.Text = (string)patientTable.Rows[0]["bed_no"];
                hd_patientId = (string)patientTable.Rows[0]["patient_id"];
                table = DbHelper.getFeeByPatientId(hd_patientId, tb_admissTimes.Text, tb_chargeCode.Text);
                if (table.Rows.Count > 0)
                {
                    dataGridView_fee.Columns["order_no"].DataPropertyName = "order_no";
                    dataGridView_fee.Columns["exec_unit"].DataPropertyName = "exec_unit";
                    dataGridView_fee.Columns["name"].DataPropertyName = "name";
                    dataGridView_fee.Columns["charge_price"].DataPropertyName = "charge_price";
                    dataGridView_fee.Columns["charge_amount"].DataPropertyName = "charge_amount";
                    dataGridView_fee.Columns["charge_status"].DataPropertyName = "charge_status";
                    dataGridView_fee.Columns["report_date"].DataPropertyName = "report_date";
                    dataGridView_fee.DataSource = table;
                    foreach (DataRow dr in table.Rows)
                    {
                        sumAmount += Convert.ToDecimal(dr["charge_amount"]);
                        sumMoney += Convert.ToDecimal(dr["charge_amount"]) * Convert.ToDecimal(dr["charge_price"]);
                    }
                    lb_sumAmount.Text = sumAmount.ToString();
                    lb_sumMoney.Text = sumMoney.ToString();
                }
                else
                {
                    MessageBox.Show("没有此病人费用信息");
                }
            }
            else
            {
                table.Rows.Clear();
                dataGridView_fee.DataSource = table;
                MessageBox.Show("没有此病人信息");
            }

            //dataGridView1.Columns["order_sn"].DataPropertyName = "order_sn"; 
            //MessageBox.Show("回车");
        }
    }
}
