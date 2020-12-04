using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AtomDataScript : MonoBehaviour
{
    public List<Atom> Atoms = new List<Atom>()
    {
        new Atom
        {
            Name="Hydrogen",
            ShortName= "H",
            Weight= "1.008",
            Number= "1",
            Description = "Hydrogen is the chemical element with the symbol H and atomic number 1. With a standard atomic weight of 1.008," +
            " hydrogen is the lightest element in the periodic table. Hydrogen is the most abundant chemical substance in the universe, constituting roughly 75% of" +
            " all baryonic mass.[7][note 1] Non-remnant stars are mainly composed of hydrogen in the plasma state. " +
            "The most common isotope of hydrogen, termed protium (name rarely used, symbol 1H), has one proton and no neutrons.",
            WikipediaLink = "https://en.wikipedia.org/wiki/Hydrogen"
        },
        new Atom
        {
            Name="Oxygen",
            ShortName= "O",
            Weight= "15.999",
            Number= "8",
            Description = "Oxygen is the chemical element with the symbol O and atomic number 8. It is a member of the chalcogen group in the periodic table," +
            " a highly reactive nonmetal, and an oxidizing agent that readily forms oxides with most elements as well as with other compounds.",
            WikipediaLink = "https://en.wikipedia.org/wiki/Oxygen"
        },
        new Atom
        {
            Name="Sulfur",
            ShortName= "S",
            Weight= "32.06",
            Number= "16",
            Description = "Sulfur (in British English: sulphur) is a chemical element with the symbol S and atomic number 16. It is abundant, " +
            "multivalent and nonmetallic. Under normal conditions, sulfur atoms form cyclic octatomic molecules with a chemical formula S8. Elemental sulfur is a bright yellow, " +
            "crystalline solid at room temperature.",
            WikipediaLink = "https://en.wikipedia.org/wiki/Sulfur"
        },
        new Atom
        {
            Name="Carbon",
            ShortName= "C",
            Weight= "12.0096",
            Number= "6",
            Description = "Carbon (from Latin: carbo 'coal') is a chemical element with the symbol C and atomic number 6. " +
            "It is nonmetallic and tetravalent—making four electrons available to form covalent chemical bonds",
            WikipediaLink = "https://en.wikipedia.org/wiki/Carbon"
        },
        new Atom
        {
            Name="Nitrogen",
            ShortName= "N",
            Weight= "14.006",
            Number= "7",
            Description = "Nitrogen is the chemical element with the symbol N and atomic number 7. " +
            "It was first discovered and isolated by Scottish physician Daniel Rutherford in 1772.",
            WikipediaLink = "https://en.wikipedia.org/wiki/Nitrogen"
        },
    };


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}


public class Atom
{
    public string Name { get; set; }
    public string ShortName { get; set; }
    public string Weight { get; set; }
    public string Number { get; set; }
    public string Description { get; set; }
    public string WikipediaLink { get; set; }
}
