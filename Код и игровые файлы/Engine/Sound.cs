using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Matrix.Engine
{
    class Sound
    {
        static public void Play(string key) => Resources.GetSound(key).Play();
    }
}
