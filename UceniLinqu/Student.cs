using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
     class Student : IEquatable<Student>
    {
        public int StudentId { get; set; }

        public int Marks { get; set; }

        public string StudentEmail { get; set; }

        public string FullName { get; set; }

        public bool Equals(Student other)
        {
            if (object.ReferenceEquals(other , null))
            {
                return false;
            }
            if (object.ReferenceEquals(this, other))
            {
                return true;
            }
            return StudentId.Equals(other.StudentId) && FullName.Equals(other.FullName);
        }

        public override int GetHashCode()
        {
            int idHashCode = StudentId.GetHashCode();
            int NameHashCode = FullName.GetHashCode();

            return idHashCode ^ NameHashCode;
        }
    }
}
