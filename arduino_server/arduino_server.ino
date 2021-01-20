
#include <Ethernet.h>
#include <EthernetUdp.h>

// Enter a MAC address and IP address for your controller below.
// The IP address will be dependent on your local network:
byte mac[] = {
  0xDE, 0xAD, 0xBE, 0xEF, 0xFE, 0xED
};
IPAddress ip(192, 168, 178, 36);

unsigned int localPort = 11000;      // local port to listen on
#define echoPin 2
#define trigPin 3
// buffers for receiving and sending data
char packetBuffer[UDP_TX_PACKET_MAX_SIZE];  // buffer to hold incoming packet,
char ReplyBuffer[] = "15";        // a string to send back
char ReplyBuffer2[] = "aangenomen";
long duration; 
int distance; 
// An EthernetUDP instance to let us send and receive packets over UDP
EthernetUDP Udp;

void setup() {
  // You can use Ethernet.init(pin) to configure the CS pin
  Ethernet.init(10);  // Most Arduino shields
   pinMode(9, OUTPUT); 
   pinMode(echoPin, INPUT);
   pinMode(trigPin, OUTPUT) ; 


  // start the Ethernet
  Ethernet.begin(mac, ip);

  // Open serial communications and wait for port to open:
  Serial.begin(9600);
  while (!Serial) {
    ; // wait for serial port to connect. Needed for native USB port only
  }

  // Check for Ethernet hardware present
  if (Ethernet.hardwareStatus() == EthernetNoHardware) {
    Serial.println("Ethernet shield was not found.  Sorry, can't run without hardware. :(");
    while (true) {
      delay(1); // do nothing, no point running without Ethernet hardware
    }
  }
  if (Ethernet.linkStatus() == LinkOFF) {
    Serial.println("Ethernet cable is not connected.");
  }
  

  // start UDP
  Udp.begin(localPort);
}
void clear() 

{

 for (int i= 0; i<UDP_TX_PACKET_MAX_SIZE; i++)

    packetBuffer[i]=0;

}
void loop() {
  // if there's data available, read a packet
  
  int packetSize = Udp.parsePacket();
  if (packetSize) {
    Serial.print("Received packet of size ");
    Serial.println(packetSize);
    Serial.print("From ");
    IPAddress remote = Udp.remoteIP();
    for (int i=0; i < 4; i++) {
      Serial.print(remote[i], DEC);
      if (i < 3) {
        Serial.print(".");
      }
    }
    Serial.print(", port ");
    Serial.println(Udp.remotePort());

    clear();
    Udp.read(packetBuffer, UDP_TX_PACKET_MAX_SIZE);
    Serial.println("Contents:");
    String test = String(packetBuffer);
    Serial.println(test.length());
    Serial.println(test);
    if(test == "sens"){
      digitalWrite(9, HIGH); 
       digitalWrite(trigPin, LOW);
  delayMicroseconds(2);
  digitalWrite(trigPin, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin, LOW);
  duration = pulseIn(echoPin, HIGH);
  distance = duration * 0.034 / 2; 
  Serial.print("Distance: ");
  Serial.print(distance);
  Serial.println(" cm");
      Udp.beginPacket(Udp.remoteIP(), Udp.remotePort());
     
String str = String(distance);
str.toCharArray(ReplyBuffer,16);
    Udp.write(ReplyBuffer);
    Udp.endPacket();
      }
     if(test == "hagel"){
      digitalWrite(9, LOW); 
      Udp.beginPacket(Udp.remoteIP(), Udp.remotePort());
    Udp.write(ReplyBuffer2);
    Udp.endPacket();
      }

   
     

    
   
    
  }
  
}    

    
   
    
  
