using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HD.Common
{
    public class CustomId
    {
        private readonly Guid _id;

        public CustomId()
        {
            this._id = Guid.NewGuid();
        }

        public CustomId(Guid guid)
        {
            this._id = guid;
        }

        public override string ToString()
        {
            return this._id.ToString();
        }

        public string ToString(string format)
        {
            return this._id.ToString(format);
        }

    }
}
