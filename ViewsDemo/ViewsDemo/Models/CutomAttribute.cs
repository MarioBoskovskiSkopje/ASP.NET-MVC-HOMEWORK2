using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewsDemo.Models
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Constructor)]
    public class CustomAttribute : Attribute
    {
        public int MaxValue { get; set; }
        public int MinValue { get; set; }

        public CustomAttribute(string ErrorMessage, string optional = null)
        {

        }
    }
}