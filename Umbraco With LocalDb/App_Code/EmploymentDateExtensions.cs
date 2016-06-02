using System;
using System.Linq;
using Umbraco.Core.Models;

namespace Umbraco_With_LocalDb.App_Code
{
    /// <summary>
    /// Extensions for an Umbraco-member that has an EmploymentDate-property of type DateTime
    /// </summary>
    public static class EmploymentDateExtensions
    {

        /// <summary>
        /// Gets the employment date for an Umbraco-membertype that has an EmploymentDate-property
        /// </summary>
        /// <param name="member">the member</param>
        /// <returns></returns>
        public static DateTime GetEmploymentDate(this IMember member)
        {
            var noDate = DateTime.Today;
            var property = GetEmploymentDateProperty(member);

            if (property == null) return noDate;
                
            var employmentDate = property.Value as DateTime?;
            return employmentDate ?? noDate;
        }

        public static void SetEmploymentDate(this IMember member, DateTime employmentDate)
        {
            var property = GetEmploymentDateProperty(member);
            if (property == null) return;
            property.Value = employmentDate;
        }
          
        private static Property GetEmploymentDateProperty(IMember member)
        {
            return member.Properties.FirstOrDefault(p => p.Alias.Equals("EmploymentDate", StringComparison.InvariantCultureIgnoreCase));
        }

    }
}