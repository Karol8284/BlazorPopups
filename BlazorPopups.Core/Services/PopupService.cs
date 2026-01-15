using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPopups.Core.Services
{
    public class PopupService
    {
        public event Action<string>? OnShow;
        public void Show(string messange)
        {
            OnShow?.Invoke(messange);
        }
    }
}
