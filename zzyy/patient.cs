using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
//using System.Linq;
//using System.Threading.Tasks;
using System.Windows.Forms;
using zzyy.Db;

namespace zzyy
{
    public partial class patient : Form
    {
        public patient()
        {
            InitializeComponent();
        }

        private DataTable table;
        string hd_patientId;

        

        private void txt_inpNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                table = DbHelper.getPatInfoByInpNo(txt_inpNo.Text, tb_admissTimes.Text);
                if (table.Rows.Count > 0)
                {
                    lbl_val_name.Text = (string)table.Rows[0]["name"];
                    lbl_val_bedNo.Text = (string)table.Rows[0]["bed_no"];
                    hd_patientId = (string)table.Rows[0]["patient_id"];
                    if (((string)table.Rows[0]["lock_order_fee"]) == "0")
                    {
                        lbl_feeLock.Text = "未锁定";
                        btn_feeLock.Enabled = false;
                    }
                    else
                    {
                        lbl_feeLock.Text = "锁定";
                        btn_feeLock.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("没有病人消息!");
                }
                
            }
        }

        private void btn_feeLock_Click(object sender, EventArgs e)
        {
            if (DbHelper.editPatientInfo(hd_patientId, tb_admissTimes.Text) > 0)
            {
                MessageBox.Show("解锁成功！");
                lbl_feeLock.Text = "未锁定";
                btn_feeLock.Enabled = false;
            }
        }
    }
}
