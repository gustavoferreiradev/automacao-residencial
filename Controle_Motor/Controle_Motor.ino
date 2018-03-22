#define CHAR_Primeiro '-'
#define CHAR_Ultimo '/'
#define CHAR_Tamanho 3

int LedPino       = 9;
int Brilho        = 0;
boolean IsLendo   = false;

void setup ()
{
  
  Serial.begin(9600);
  
}

void loop ()
{

  if( Serial.available() && IsLendo == false )
  {
    
    if( Serial.read() == CHAR_Primeiro )
    {
    
      IsLendo         = true;
      
      char SerialDados[3];
      int i           = 0;
      int SerialInt   = 0;
      int CharAtual   = 0;
      
      iniReading:
      if (Serial.available() > 0) 
      {
      
        CharAtual = Serial.read();
        
        if (CharAtual == CHAR_Ultimo || i >= CHAR_Tamanho ) 
        {
        
          goto endReading;
          
        } else {
        
          SerialDados[i++] = CharAtual;
          goto iniReading;
          
        }
      
      }
      
      goto iniReading;
      endReading:  
         
      SerialInt       = atoi(SerialDados);
      
      if( Brilho != SerialInt && i == CHAR_Tamanho )
      {
      
        Brilho          = SerialInt;        
        analogWrite (LedPino, Brilho);
      
      }    
    
      IsLendo = false;
    
    }
   
  }
  
}
