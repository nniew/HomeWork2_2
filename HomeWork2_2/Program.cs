using System;

class Program {
  static bool IsValidSequence(string halfDNASequence){
    foreach(char nucleotide in halfDNASequence){
      if(!"ATCG".Contains(nucleotide)){return false;}
    }
    return true;
  }

  static string ReplicateSeqeunce(string halfDNASequence){
    string result = "";
    foreach(char nucleotide in halfDNASequence){
      result +=
      "TAGC"["ATCG".IndexOf(nucleotide)];
    }
    return result;
  }

  static void RunProgram(){
    string dna, replicate, halfDna;
    dna = Console.ReadLine();
    bool dnaIsValidSequence = IsValidSequence(dna);
    if (dnaIsValidSequence) {
      Console.WriteLine("Current half DNA sequence :" + dna );
      while (true){
        Console.WriteLine("Do you want to replicate it ? (Y/N) :");
        replicate = Console.ReadLine();
        if (replicate == "Y"){
          halfDna = ReplicateSeqeunce(dna);
          Console.WriteLine("Replicated half DNA sequence :" + halfDna);
          return;
        }
        else if (replicate == "N"){
            return;
        }
        else {
          Console.WriteLine("Please input Y or N.");
          continue;
        }
      }
    }
    else {
      Console.WriteLine("That half DNA sequence is invalid.");
      return;
    }
  }

  public static void Main (string[] args) {
    RunProgram();
    while (true) {
      Console.WriteLine("Do you want to process another sequence ? (Y/N) :");
      string again;
      again = Console.ReadLine();
      if (again == "Y") {
        RunProgram();
        continue;
      }
      else if (again == "N"){
        break;
      }
      else {
        Console.WriteLine("Please input Y or N.");
        continue;
      }
    }
  }
}