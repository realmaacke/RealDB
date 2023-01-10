using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealDB.src.Syntax
{
    public abstract class Commands
    {

        public List<Cmds> cmds = new List<Cmds>()
        {
            new Cmds
            {
                name = "SELECT",
                hasArgs = true
            },

            new Cmds
            {
                name = "INSERT",
                hasArgs = true
            },

            new Cmds
            {
                name = "DELETE",
                hasArgs = true
            },

            new Cmds
            {
                name = "CREATE",
                hasArgs = true
            },

            new Cmds
            {
                name = "VIEW",
                hasArgs = true,
            }
        };

        public List<args> parameters = new List<args>()
        {
            new args
            {
                name = "table",
            },
            new args
            {
                name = "database",
            }
        };
    }

    public struct Cmds
    {
        public string name;
        public bool hasArgs;
    }

    public struct args { public string name; }
}
