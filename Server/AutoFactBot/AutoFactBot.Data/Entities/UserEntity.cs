using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFactBot.Data.Entities
{
    public class UserEntity
    {
        public long Id { get; set; }

        public string UserName { get; set; } = string.Empty;

        public List<DocumentEntity> Documents { get; set; } = [];
    }
}
