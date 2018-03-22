int ledcozinha = 50;
int ledquarto1 = 38;
int ledquarto2 = 41;
int ledsala = 36;
int ledquarto3 = 22;
int ledbanheiro = 47;
int motorPin1 = 7;
int motorPin2 = 8;
int armazena = 0;
int Vent = 9;
//int enablePin = 10;

void setup (){
  Serial.begin(9600);
  pinMode (ledcozinha, OUTPUT);
  pinMode (ledquarto1, OUTPUT);
  pinMode (ledquarto2, OUTPUT);
  pinMode (ledsala, OUTPUT);
  pinMode (ledquarto3, OUTPUT);
  pinMode (motorPin1, OUTPUT);
  pinMode (motorPin2, OUTPUT);
  pinMode (ledbanheiro, OUTPUT);
//  pinMode (enablePin,OUTPUT);
//  digitalWrite(enablePin,HIGH);
}

void loop(){
  
  if (Serial.available()){
    armazena = Serial.read();
    
    if (armazena==54){
      digitalWrite (ledcozinha,HIGH);
    }
    
    if (armazena==55){
    digitalWrite (ledcozinha,LOW);
    }
    
    if (armazena==50){
    digitalWrite (ledquarto1,HIGH);   
  }
  if (armazena==51){
   digitalWrite (ledquarto1,LOW);
}

  if(armazena==52){
  digitalWrite(ledquarto2,HIGH);
  }
  if(armazena==53){
  digitalWrite(ledquarto2,LOW);
  }
  
  if(armazena==56){
    digitalWrite(ledquarto3,HIGH);
  }
  if(armazena==57){
    digitalWrite(ledquarto3,LOW);
  
}

  if(armazena==49){
    digitalWrite(ledsala, HIGH);
  }
  
  if(armazena==48){
    digitalWrite(ledsala, LOW);
  }
if(armazena=='e'){
  digitalWrite(motorPin1, 1);
  digitalWrite(motorPin2, 0);
  }
  else if(armazena=='d'){
  digitalWrite(motorPin1, 0);
  digitalWrite(motorPin2, 1); 
}
else { 
  digitalWrite(motorPin1, 0);
  digitalWrite(motorPin2, 0);
}

if (armazena=='q'){
  digitalWrite(ledbanheiro, HIGH);
   }
   
 if(armazena=='w'){
   digitalWrite(ledbanheiro, LOW);
}
  }
  
if (armazena=='v'){
  
  analogWrite(Vent,255);
}

if (armazena=='b'){
  analogWrite(Vent, 0);
}
}



