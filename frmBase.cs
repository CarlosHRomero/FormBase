using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBase
{
    public partial class frmBase : Form
    {
        protected virtual string Titulo { get; set; }
        public frmBase()
        {
            InitializeComponent();
        }
        public virtual void Actualizar()
        {
            throw new NotImplementedException();
        }
    }
}
