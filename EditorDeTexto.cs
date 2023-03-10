using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Componentes1
{
    public partial class EditorDeTexto : Component
    {
        public EditorDeTexto()
        {
            InitializeComponent();
        }

        public EditorDeTexto(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
