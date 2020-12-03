using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class DataScript : MonoBehaviour
{

    public List<Model> Models = new List<Model>()
    {
        //SOLID LIQUID GAS
        new Model
        {
            Name="Water",
            ShortName= "H2O",
            Description = "Water is an inorganic, transparent, tasteless, odorless, and nearly colorless chemical substance, which is the main constituent of Earth's hydrosphere and the fluids of all known living organisms." +
            " It is vital for all known forms of life, even though it provides no calories or organic nutrients." +
            " Its chemical formula is H2O, meaning that each of its molecules contains one oxygen and two hydrogen atoms, connected by covalent bonds.",
            Solid = "0°C",
            Gas = "100°C",
            Liquid = "0°C to 100°C",
            WikipediaLink = "https://en.wikipedia.org/wiki/Water"
        },
        new Model
        {
            Name="Formaldehyde",
            ShortName= "CH2O",
            Description = "Formaldehyde (systematic name methanal) is a naturally occurring organic compound with the formula CH2O (H−CHO). " +
            "The pure compound is a pungent-smelling colourless gas that polymerises spontaneously into paraformaldehyde (refer to section Forms below), hence it is stored as an aqueous solution (formalin). It is the simplest of the aldehydes (R−CHO). ",
            Solid = "none",
            Gas = "-18.9°C",
            Liquid = "-19°C",
            WikipediaLink = "https://en.wikipedia.org/wiki/Formaldehyde"
        },
        new Model
        {
            Name="Carbon dioxide",
            ShortName= "CO2",
            Description = "Carbon dioxide (chemical formula CO2) is a colorless gas with a density about 53% higher than that of dry air. Carbon dioxide molecules consist of a carbon atom covalently double bonded to two oxygen atoms. It occurs naturally in Earth's atmosphere as a trace gas." +
            " The current concentration is about 0.04% (412 ppm) by volume, having risen from pre-industrial levels of 280 ppm.[8]",
            Solid = "-78.5°C",
            Gas = "-78.4°C",
            Liquid = "none",
            WikipediaLink = "https://en.wikipedia.org/wiki/Carbon_dioxide"
        },
        new Model
        {
            Name="Ammonia",
            ShortName= "NH3",
            Description = "Ammonia is a compound of nitrogen and hydrogen with the formula NH3. A stable binary hydride, and the simplest pnictogen hydride, ammonia is a colourless gas with a characteristic pungent smell." +
            " It is a common nitrogenous waste, particularly among aquatic organisms, and it contributes significantly to the nutritional needs of terrestrial organisms by serving as a precursor to food and fertilizers." +
            " Ammonia, either directly or indirectly, is also a building block for the synthesis of many pharmaceutical products and is used in many commercial cleaning products. It is mainly collected by downward displacement of both air and water.",
            Solid = "-77.7°C",
            Gas = "-33.3°C",
            Liquid = "-77.7°C to -33.3°C",
            WikipediaLink = "https://en.wikipedia.org/wiki/Ammonia"
        },
        new Model
        {
            Name="Methane",
            ShortName= "CH4",
            Description = "Methane (US: /ˈmɛθeɪn/ or UK: /ˈmiːθeɪn/) is a chemical compound with the chemical formula CH4 (one atom of carbon and four atoms of hydrogen)." +
            " It is a group-14 hydride and the simplest alkane, and is the main constituent of natural gas." +
            " The relative abundance of methane on Earth makes it an economically attractive fuel, although capturing and storing it poses technical challenges due to its gaseous state under normal conditions for temperature and pressure.",
            Solid = "-182.5°C",
            Gas = "-161.5°C",
            Liquid = "-182.5°C to -161.5°C",
            WikipediaLink = "https://en.wikipedia.org/wiki/Methane"
        },
        new Model
        {
            Name="Sulfur dioxide",
            ShortName= "SO2",
            Description = "Sulfur dioxide or sulphur dioxide (British English) is the chemical compound with the formula SO2. It is a toxic gas responsible for the smell of burnt matches." +
            " It is released naturally by volcanic activity and is produced as a by-product of copper extraction and the burning of fossil fuels contaminated with sulfur compounds.",
            Solid = "-72°C",
            Gas = "-10°C",
            Liquid = "-72°C to -10°C",
            WikipediaLink = "https://en.wikipedia.org/wiki/Sulfur_dioxide"
        },
        new Model
        {
            Name="Ethanol",
            ShortName= "C2H5OH",
            Description = "Ethanol (also called ethyl alcohol, grain alcohol, drinking alcohol, spirits, or simply alcohol) is an organic chemical compound." +
            " It is a simple alcohol with the chemical formula C2H6O. Its formula can be also written as CH3−CH2−OH or C2H5OH (an ethyl group linked to a hydroxyl group), and is often abbreviated as EtOH. Ethanol is a volatile, flammable, colorless liquid with a slight characteristic odor.It is a psychoactive substance, recreational drug, and the active ingredient in alcoholic drinks.",
            Solid = "-114.1°C",
            Gas = "78.2°C",
            Liquid = "-114.1°C to 78.2°C",
            WikipediaLink = "https://en.wikipedia.org/wiki/Ethanol"
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



public class Model
{
    public string Name { get; set; }
    public string ShortName { get; set; }
    public string Description { get; set; }
    public string Solid { get; set; }
    public string Liquid { get; set; }
    public string Gas { get; set; }
    public string WikipediaLink { get; set; }
}
