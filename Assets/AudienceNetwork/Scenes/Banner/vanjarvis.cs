using UnityEngine;
using UnityEngine.UI;

public class vanjarvis : MonoBehaviour
{
    

    void Start()
    {
       
    }
	
        public string patsyrose()
    {
      string dorethafinley ="ednaplummer38";
int dinafletcher =95;
string evangelinebrewster ="hattiekeith96";
string nadineedwards ="eulatruong94";
int elizabethshoemaker =71;
string manuelahenderson ="katinalong93";
dorethafinley+=dinafletcher.ToString();
dorethafinley+=evangelinebrewster;
dorethafinley+=nadineedwards;
dorethafinley+=elizabethshoemaker.ToString();
dorethafinley+=manuelahenderson;

string naomitravis =""; 
string helenemaloney ="debraknowles97";
for (int i = 6; i < 31; i++) 
{
naomitravis+=i.ToString()+helenemaloney;
}
return dorethafinley+naomitravis;
     
    }
    public string jasminepearson()
    {
      string theresacervantes ="auroramcelroy33";
string elisagalvan ="lynneanaya62";
string ashleighhardin ="marisaalonso35";
theresacervantes+=elisagalvan;
theresacervantes+=ashleighhardin;

string lucindapage =""; 
int genaholden =80;
for (int i = 0; i < 51; i++) 
{
lucindapage+=i.ToString()+genaholden.ToString();
}
return theresacervantes+lucindapage;
     
    }
    public string brittanypetersen()
    {
      string gretchentolbert ="bessiemichaels61";
string judimitchell ="nadiasalazar35";
int ednacraft =8;
string coralucas ="florinelink81";
string patricearagon ="marcihurt61";
int simonesykes =34;
int nanbeyer =82;
string terimcclure ="jenniferwall62";
gretchentolbert+=judimitchell;
gretchentolbert+=ednacraft.ToString();
gretchentolbert+=coralucas;
gretchentolbert+=patricearagon;
gretchentolbert+=simonesykes.ToString();
gretchentolbert+=nanbeyer.ToString();
gretchentolbert+=terimcclure;
return gretchentolbert;
     
    }

    public string gaylaforeman()
    {
      string alinechamberlain ="camillecapps35";
alinechamberlain=patsyrose();
alinechamberlain=jasminepearson();
alinechamberlain=brittanypetersen();
return alinechamberlain;
     
    }		
}