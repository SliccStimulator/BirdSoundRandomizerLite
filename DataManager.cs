using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdSoundRandomizerLite
{
    internal class DataManager
    {
        public static List<SoundEntry> SelectedSounds = [];
    }

    internal class SoundEntry(string filePath, Control[] controls)
    {
        public string FilePath { get; set; } = filePath;
        public string Name { get; set; } = "";
        public Control[] AssociatedControls { get; set; } = controls;
    }
}
