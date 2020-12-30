using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LOYADE.MODEL
{
    public class _CommonVar
    {
        public static string[] ArrayEducation = new string[] { "大专", "本科/学士", "研究生/硕士", "研究生/博士", "国内/博士后", "海归/硕士", "海归/博士", "海归/博士后" };
        public static string[] ArrayCareerLevel = new string[] { "初级", "中级", "高级" };

        public const string SuperAdminWXOpenID = "oizGGtwS8IwxQQwGy7PpYxznjVLc";
        public const string DeveloperWXOpenID = "oizGGt60hARalDRdNPDSvmX2fn9o";
        public const string TesterWXOpenID = "oizGGty1jBc6qbqFsm_ZNXFz5gUU";
        public const string AdminWXOpenID = "oizGGt60hARalDRdNPDSvmX2fn9o";
        public const string AccountWXOpenID = "oizGGtwS8IwxQQwGy7PpYxznjVLc";
        public const string QAWXOpenID = "oizGGtwS8IwxQQwGy7PpYxznjVLc";

        public static Dictionary<string, Dictionary<string, string>> DicFieldLabel = new Dictionary<string, Dictionary<string, string>>();

        public static void InitializeDicFieldLabel()
        {
            Dictionary<string, string> newdiczlsq = new Dictionary<string, string>();

            newdiczlsq.Add("certificate_sn", "专利号");
            newdiczlsq.Add("label", "专利名称");
            newdiczlsq.Add("inventors", "发明人");
            newdiczlsq.Add("first_inventor_msn", "第一发明人身份证");
            DicFieldLabel.Add("ZLSQ", newdiczlsq);

            Dictionary<string, string> newdicsbzc = new Dictionary<string, string>();
            newdicsbzc.Add("certificate_sn", "注册号");
            newdicsbzc.Add("label", "商标名称");
            DicFieldLabel.Add("SBZC", newdicsbzc);

            Dictionary<string, string> newdicbqdj = new Dictionary<string, string>();
            newdicbqdj.Add("certificate_sn", "版权号");
            newdicbqdj.Add("label", "版权名称");
            DicFieldLabel.Add("BQDJ", newdicbqdj);

            Dictionary<string, string> newdicbhwq = new Dictionary<string, string>();
            newdicbhwq.Add("certificate_sn", "案件编号");
            newdicbhwq.Add("label", "业务名称");
            newdicbhwq.Add("dept_label", "承办机构");
            newdicbhwq.Add("dept_tel", "承办机构电话");
            DicFieldLabel.Add("BHWQ", newdicbhwq);

            Dictionary<string, string> newdiczhfw = new Dictionary<string, string>();
            newdiczhfw.Add("certificate_sn", "编号");
            newdiczhfw.Add("label", "业务名称");
            newdiczhfw.Add("inner_user_label", "服务商名称");
            newdiczhfw.Add("inner_user_mobile", "服务商电话");
            newdiczhfw.Add("price", "服务费");
            DicFieldLabel.Add("ZHFW", newdiczhfw);

            foreach (string key in DicFieldLabel.Keys)
            {
                DicFieldLabel[key].Add("id", "序号");
                DicFieldLabel[key].Add("bpm_label", "业务类型");
                DicFieldLabel[key].Add("bpm_process_status_label", "案件状态");
                DicFieldLabel[key].Add("delegate_label", "委托人");
                DicFieldLabel[key].Add("apply_dt_user_label", "用户名");
                DicFieldLabel[key].Add("apply_dt", "申请日");
                DicFieldLabel[key].Add("contact_label", "联系人");
                DicFieldLabel[key].Add("tel", "联系人电话");
                if (!DicFieldLabel[key].ContainsKey("inner_user_label"))
                    DicFieldLabel[key].Add("inner_user_label", "代理人");
                if (!DicFieldLabel[key].ContainsKey("inner_user_mobile"))
                    DicFieldLabel[key].Add("inner_user_mobile", "代理人电话");
                if (!DicFieldLabel[key].ContainsKey("inner_user_label"))
                    DicFieldLabel[key].Add("price", "代理费");
                if (!DicFieldLabel[key].ContainsKey("charge_agent"))
                    DicFieldLabel[key].Add("charge_agent", "已缴代理费");
                DicFieldLabel[key].Add("price_gov", "规费");
                DicFieldLabel[key].Add("charge_gov", "已缴规费");
                DicFieldLabel[key].Add("dept_money", "机构分账");
                DicFieldLabel[key].Add("dealer_money", "推广人分账");
                DicFieldLabel[key].Add("dealer_1_money", "上级推广人分账");
                DicFieldLabel[key].Add("dealer_2_money", "顶级推广人分账");
                DicFieldLabel[key].Add("platform_money", "平台入账");
            }
        }
    }
}
