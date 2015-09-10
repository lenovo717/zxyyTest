using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
//using System.Linq;
//using System.Threading.Tasks;
using System.Text;


namespace zzyy.Db
{
      class DbHelper
    {
         static DbUtility db = new DbUtility(DbProviderType.SqlServer);
         static string sql;
         static Boolean isDelete = false;
        public static  DataTable getPatInfoByInpNo(string inpNo,string visit_times)
        {

            sql = string.Format("select za.patient_id, za.inpatient_no,za.admiss_times,za.name,za.bed_no,pe.lock_order_fee FROM zy_actpatient za ,cisdb_yyy.dbo.patient_encounter pe WHERE za.patient_id=pe.patient_id and za.admiss_times  =pe.in_visit_times and za.inpatient_no='{0}' and za.admiss_times={1}", inpNo, visit_times);
            return db.ExecuteDataTable(sql, null);
        }

        public static DataTable getOrderByPatientId(string patientId, string visit_times)
        {
            sql  = string.Format(
                        "SELECT g.order_sn,g.display_name,g.long_once_flag,g.effective_time_b,g.stop_time,g.order_status,g.doc_note " +
  "FROM cisdb_yyy.dbo.general_order g WHERE enc_id = (" +
    "SELECT pe.patient_encounter_id" +
     " FROM cisdb_yyy.dbo.patient_encounter pe WHERE pe.patient_id='{0}' and pe.in_visit_times = {1}) order by long_once_flag, effective_time_b ", patientId, visit_times);
            return db.ExecuteDataTable(sql, null);
        }

        public static DataTable getFeeByPatientId(string patientId, string visit_times,string charge_code)
        {
            sql = string.Format(
                        "select c.order_no,c.exec_unit,  i.name , c.charge_price,c.charge_amount, c.charge_status ,c.report_date"+ 
                         " from view_zy_detail_charge_c c , zd_charge_item i  "+
                         " where c.charge_code=i.code and  c.patient_id='{0}' and admiss_times={1} and charge_code={2}", patientId, visit_times,charge_code);
            return db.ExecuteDataTable(sql, null);
        }
        private static DbTransaction trans = null;
        private static DbCommand command = null;
        public static Boolean delFeeByPatientId(string patient_id,string admiss_times,string charge_code)
        {
            DbConnection con = db.open();
            command = con.CreateCommand();
            trans = con.BeginTransaction();
            command.Transaction = trans;
            try { 
                            sql = string.Format("insert into zy_detail_charge_zzdelete(patient_id,admiss_times,ledger_sn,detail_sn,occ_time,confirm_time,happen_date,charge_code,bill_item_code,audit_code,orig_price,charge_price,charge_amount,charge_group,apply_opera,confirm_opera,charge_status,infant_flag,self_flag,separate_flag,suprice_flag,drug_flag,emergency_flag,ope_flag,apply_status,pay_self,serial,ward_sn,dept_sn,order_no,exec_unit,group_no,page_no,page_type,report_date,adt_dept_no,back_flag,orig_dept,orig_ward,cash_date,account_date,doctor_code,samp_id,occ_page_no,fit_flag,samp_barcode,samp_type,charge_fee,parent_detail_sn) select patient_id,admiss_times,ledger_sn,detail_sn,occ_time,confirm_time,happen_date,charge_code,bill_item_code,audit_code,orig_price,charge_price,charge_amount,charge_group,apply_opera,confirm_opera,charge_status,infant_flag,self_flag,separate_flag,suprice_flag,drug_flag,emergency_flag,ope_flag,apply_status,pay_self,serial,ward_sn,dept_sn,order_no,exec_unit,group_no,page_no,page_type,report_date,adt_dept_no,back_flag,orig_dept,orig_ward,cash_date,account_date,doctor_code,samp_id,occ_page_no,fit_flag,samp_barcode,samp_type,charge_fee,parent_detail_sn FROM view_zy_detail_charge_c   where patient_id ='{0}' and admiss_times = {1} and charge_code = '{2}' ", patient_id, admiss_times, charge_code);
                            //insert into zy_detail_charge_zzdelete select [patient_id] ,[admiss_times],[ledger_sn],[detail_sn],[occ_time],[confirm_time],[happen_date],[charge_code] ,[bill_item_code] ,[audit_code] ,[orig_price] ,[charge_price],[charge_amount],[charge_group] ,[apply_opera] ,[confirm_opera],[charge_status] ,[infant_flag] ,[self_flag],[separate_flag] ,[suprice_flag],[drug_flag] ,[emergency_flag],[ope_flag],[apply_status] ,[pay_self] ,[serial] ,[ward_sn],[dept_sn] ,[order_no] ,[exec_unit] ,[group_no] ,[page_no] ,[page_type],[report_date],[adt_dept_no] ,[back_flag],[orig_dept] ,[orig_ward],[cash_date] ,[account_date] ,[doctor_code] ,[samp_id] ,[occ_page_no],[fit_flag] ,[samp_barcode] ,[samp_type],[charge_fee] ,[parent_detail_sn] ,[exec_time],[exec_status],[charge_sort] from view_zy_detail_charge_c 
                            if (db.ExecuteNonQueryByTrans(sql, null,command) > 0)
                            {
                                 sql = string.Format("delete from zy_detail_charge where patient_id ='{0}' and admiss_times ={1}  and charge_code ={2} ", patient_id, admiss_times, charge_code);
                                 if (db.ExecuteNonQueryByTrans(sql, null,command) > 0)
                                     isDelete = true;
                                 sql = string.Format("delete from zy_detail_charge_b where patient_id ='{0}' and admiss_times ={1}  and charge_code ={2} ", patient_id, admiss_times, charge_code);
                                 if (db.ExecuteNonQueryByTrans(sql, null,command)>0) 
                                     isDelete = true;
                                 sql = string.Format("delete from zy_detail_charge_c where patient_id ='{0}' and admiss_times ={1}  and charge_code ={2} ", patient_id, admiss_times, charge_code);
                                 if (db.ExecuteNonQueryByTrans(sql, null,command) > 0)   
                                     isDelete = true;
                            }
                            trans.Commit();
            
            }catch(Exception e)
            {
                try
                {
                    trans.Rollback();
                }
                catch (SqlException ex)
                {
                    if (con != null)
                        con.Close();
                    if (trans.Connection != null)
                    {
                        trans.Connection.Close();
                    }
                }
            }
            
            
            return isDelete;
        }

        public static int clearOrderPrintByPatientId(string patient_id, string admiss_times,int longOnceFlag)
        {
            string enc_id = null;
           
                sql = string.Format("SELECT pe.patient_encounter_id  FROM cisdb_yyy.dbo.patient_encounter pe WHERE pe.patient_id='{0}' and pe.in_visit_times = {1}", patient_id, admiss_times);
                enc_id = (db.ExecuteDataTable(sql,null)).Rows[0][0].ToString();
                if (enc_id != null)
                {
                    sql = string.Format("update cisdb_yyy.dbo.general_order set print_order=0 where enc_id ='{0}' and input_type='d' and long_once_flag={1} and  order_sn not in (select order_sn from cisdb_yyy.dbo.nis_order_print where enc_id='{0}' and always_flag={1}) and print_order !=0", enc_id, longOnceFlag);
                    return db.ExecuteNonQuery(sql, null);
                }
                else
                    return 0;  
        }

        public static int editPatientInfo(String patient_id,string visit_times)
        {
            sql = string.Format("update cisdb_yyy.dbo.patient_encounter set lock_order_fee=0 where patient_id='{0}' and in_visit_times={1}",patient_id,visit_times);
            return db.ExecuteNonQuery(sql, null);
        }
          

    }

   


}
