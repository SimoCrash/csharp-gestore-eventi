using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Evento
    {
        DateTime timeNow = DateTime.Now;    
        string titolo;
        DateTime data;
        int capienzaMassimaEvento;
        int postiPrenotati = 0;

        public string getTitolo()
        {
            return this.titolo;
        }

        public void setTitolo(string titolo)
        {
            this.titolo = titolo != "" ? titolo : throw new Exception();
        }

        public DateTime getData()
        {
            return this.data;
        }

        public void setData(DateTime data)
        {
            this.data = data > this.timeNow ? data : throw new Exception();
        }

        public int getCapienzaMassimaEvento()
        {
            if(capienzaMassimaEvento >= 0) return capienzaMassimaEvento;
            else throw new Exception();
        }

        public int getPostiPrenotati() => this.postiPrenotati;

        internal object? getData(string v)
        {
            throw new NotImplementedException();
        }

        public Evento(string titolo, DateTime data, int capienzaMassimaEvento, int postiPrenotati)
        {
            this.titolo = titolo;
            this.data = data;
            this.capienzaMassimaEvento = capienzaMassimaEvento;
            this.postiPrenotati = postiPrenotati;
        }
    }
}

//Per prima cosa è necessario creare una classe Evento che abbia i seguenti attributi:
//●	titolo
//●	data
//●	capienza massima dell’evento
//●	numero di posti prenotati

//Aggiungere metodi getter e setter in modo che:
//●	titolo sia in lettura e in scrittura
//●	data sia in lettura e scrittura
//●	numero di posti per la capienza massima sia solo in lettura
//●	numero di posti prenotati sia solo in lettura
//ai setters inserire gli opportuni controlli in modo che la data non sia già passata, che il titolo non sia vuoto e che la capienza massima di posti sia un numero positivo. In caso contrario sollevare opportune eccezioni.
//Dichiarare un costruttore che prenda come parametri il titolo, la data e i posti a disposizione e inizializza gli opportuni attributi facendo uso dei metodi e controlli già fatti. Per l’attributo posti prenotati invece si occupa di inizializzarlo lui a 0.


