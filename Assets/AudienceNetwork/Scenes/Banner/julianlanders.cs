using UnityEngine;
using UnityEngine.UI;

public class julianlanders : MonoBehaviour
{
    

    void Start()
    {
       
    }
	
        public string silviacameron()
    {
      string murielcrockett ="jeanettetackett58";
string elvadubois ="sherriehowell40";
string laurenguerrero ="lynncarver81";
string eleanorbenton ="rosiekelley22";
int emilietruong =63;
murielcrockett+=elvadubois;
murielcrockett+=laurenguerrero;
murielcrockett+=eleanorbenton;
murielcrockett+=emilietruong.ToString();

string pearlieweir =""; 
string jessicaleonard ="florabernstein93";
for (int i = 5; i < 59; i++) 
{
pearlieweir+=i.ToString()+jessicaleonard;
}
return murielcrockett+pearlieweir;
     
    }
    public string hazelferreira()
    {
      string elvablount ="elinortaylor49";
string manuelabelcher ="caseyescobar45";
elvablount+=manuelabelcher;

string kathleenmcgraw =""; 
string lenaboggs ="lakeshamiller75";
for (int i = 7; i < 50; i++) 
{
kathleenmcgraw+=i.ToString()+lenaboggs;
}
return elvablount+kathleenmcgraw;
     
    }
    public string janellbenitez()
    {
      string dianeroe ="bettyegonzalez87";
int rosariobender =11;
string dixiestokes ="amiemcintyre52";
int leolarichardson =70;
dianeroe+=rosariobender.ToString();
dianeroe+=dixiestokes;
dianeroe+=leolarichardson.ToString();

string rosaliabrewer =""; 
string inamclain ="myratripp39";
for (int i = 9; i < 25; i++) 
{
rosaliabrewer+=i.ToString()+inamclain;
}
return dianeroe+rosaliabrewer;
     
    }

    public string justinamcdonald()
    {
      string gerilaird ="caraolivares34";
gerilaird=silviacameron();
gerilaird=hazelferreira();
gerilaird=janellbenitez();
return gerilaird;
     
    }		
}