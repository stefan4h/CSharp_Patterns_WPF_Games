using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Sekretär
{
    class Sekretaerin
    {
        public void schreibenVersenden(String text)
        {
            //Gegeben: Alle benötigten Klassen sind korrekt instanziiert, initialisiert und bekannt
            Computer computer = new Computer();
            Drucker drucker = new Drucker();
            Stift stift = new Stift();
            Stempel stempel = new Stempel();
            Briefmarkenautomat briefmarkenautomat = new Briefmarkenautomat();
            Briefkasten briefkasten = new Briefkasten();
            //Computer muss angeschaltet werden.
            computer.An();
            //Das Textverarbeitungsprogramm muss geöffnet werden.
            Textverarbeitungsprogramm textverarbeitungsprog = computer.getTextverarbeitungsprogramm();
            textverarbeitungsprog.Oeffnen();
            //Mit dem Textverarbeitungsprogramm muss das Dokument erstellt werden
            Dokument dokument = textverarbeitungsprog.GetDokument(text);
            //Drucker muss angeschaltet werden
            drucker.An();
            //Drucker muss konfiguriert werden
            drucker.Konfigurieren();
            //Papier muss in den Drucker gelegt werden
            drucker.PapierNachfuellen();
            //Das Dokument muss gedruckt werden
            computer.Drucke(dokument);
            //Der Drucker sollte ausgeschaltet werden
            drucker.Aus();
            //Der Computer sollte ausgeschaltet werden
            computer.Aus();
            //Das Dokument muss mit dem Stift unterschrieben werden
            stift.Unterschreiben(dokument);
            //Das Dokument muss mit dem Stempel gestempelt werden
            stempel.Stempeln(dokument);
            //Das Dokument muss mit Hilfe des Briefmarkenautomaten frankiert werden
            briefmarkenautomat.BriefmarkeBezahlen(dokument, 2);
            //Das Dokument muss schließlich in den Briefkasten geworfen werden.
            briefkasten.briefEinwerfen(dokument);
        }
    }
}
