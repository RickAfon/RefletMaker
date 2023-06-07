using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace RefletMaker
{
    public partial class MainWindow : Window
    {
        private string[] classes = { "Lord M", "Lord F", "Great Lord M",
            "Great Lord F", "Tactician M", "Tactician F", "Grandmaster M",
            "Grandmaster F", "Cavalier M", "Cavalier F", "Knight M", "Knight F",
            "Paladin M", "Paladin F", "Great Knight M", "Great Knight F", "General M",
            "General F", "Barbarian", "Fighter", "Mercenary M", "Mercenary F", "Archer M",
            "Archer F", "Berserker", "Warrior", "Hero M", "Hero F", "Bow Knight M",
            "Bow Knight F", "Sniper M", "Sniper F", "Myrmidon M", "Myrmidon F",
            "Thief M", "Thief F", "Swordmaster M", "Swordmaster F", "Assassin M",
            "Assassin F", "Trickster M", "Trickster F", "Pegasus Knight", "Falcon Knight",
            "Dark Flier", "Wyvern Rider M", "Wyvern Rider F", "Wyvern Lord M", "Wyvern Lord F",
            "Griffon Rider M", "Griffon Rider F", "Troubadour", "Priest", "Cleric", "Mage M",
            "Mage F", "Dark Mage M", "Dark Mage F", "Valkyrie", "War Monk", "War Cleric", "Sage M",
            "Sage F", "Dark Knight M", "Dark Knight F", "Sorcerer M", "Sorcerer F", "Dancer",
            "Manakete", "Taguel M", "Taguel F", "Soldier", "Villager", "Mercheant", "Reverant",
            "Entombed", "Conqueror", "Lodestar", "Grima", "Mirage", "Dread Fighter", "Bride"
        };

        private void bindComboBox()
        {

        }
        public MainWindow()
        {
            InitializeComponent();
            bindComboBox();
        }

        private void classbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void NumTB(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
