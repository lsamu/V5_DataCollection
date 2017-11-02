using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V5_WinLibs.Expand
{
    public class ListItem : System.Object
    {
        private string m_sValue = string.Empty;
        private string m_sText = string.Empty;

        /// <summary>
        /// 值
        /// </summary>
        public string Value
        {
            get { return this.m_sValue; }
        }
        /// <summary>
        /// 显示的文本
        /// </summary>
        public string Text
        {
            get { return this.m_sText; }
        }

        public ListItem(string value, string text)
        {
            this.m_sValue = value;
            this.m_sText = text;
        }
        public override string ToString()
        {
            return this.m_sText;
        }
        public override bool Equals(System.Object obj)
        {
            if (this.GetType().Equals(obj.GetType()))
            {
                ListItem that = (ListItem)obj;
                return (this.m_sText.Equals(that.Value));
            }
            return false;
        }
        public override int GetHashCode()
        {
            return this.m_sValue.GetHashCode(); ;
        }
    }
}
