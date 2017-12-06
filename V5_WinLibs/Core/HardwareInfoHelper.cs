using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace V5_WinLibs.Core {
    public class HardwareInfoHelper {
        public string GetHostName() {
            return System.Net.Dns.GetHostName();
        }
        public String GetCpuID() {
            try {
                ManagementClass mc = new ManagementClass("Win32_Processor");
                ManagementObjectCollection moc = mc.GetInstances();
                String strCpuID = null;
                foreach (ManagementObject mo in moc) {
                    strCpuID = mo.Properties["ProcessorId"].Value.ToString();
                    break;
                }
                return strCpuID;
            }
            catch {
                return "";
            }
        }
        public String GetHardDiskID() {
            try {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
                String strHardDiskID = null;
                foreach (ManagementObject mo in searcher.Get()) {
                    strHardDiskID = mo["SerialNumber"].ToString().Trim();
                    break;
                }
                return strHardDiskID;
            }
            catch {
                return "";
            }
        }
        /// <summary>
        /// 获取主板序列号
        /// </summary>
        /// <returns></returns>
        public string GetBordSerial() {
            try {
                SelectQuery query = new SelectQuery("SELECT * FROM Win32_BaseBoard");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
                ManagementObjectCollection.ManagementObjectEnumerator enumerator = searcher.Get().GetEnumerator();
                enumerator.MoveNext();
                return enumerator.Current.GetPropertyValue("SerialNumber").ToString();
            }
            catch {
                return "";
            }
        }
        /// <summary>
        /// 获取内存序列号
        /// </summary>
        /// <returns></returns>
        public string GetProcessorId() {
            string str = string.Empty;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_Processor");
            foreach (ManagementObject obj2 in searcher.Get()) {
                return obj2.Properties["ProcessorId"].Value.ToString();
            }
            return str;
        }





    }
}
