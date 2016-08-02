import java.io.IOException;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.SocketException;
import java.util.ArrayList;


public class Redirection extends Server {
	private ArrayList<Server> serverList;
	private byte [] ackBuf = "!".getBytes();
	DatagramPacket acknowledge;
	
	public Redirection(String user) {
		// TODO write this
		super(user);
		try {
			data = new DatagramSocket(super.redirectionPort);
		} catch (SocketException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		try {
			data.setSoTimeout(500);
		} catch (SocketException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		

	}

	//logic for the redirection
	//TODO write this
	public void doStuff(){
		byte []buf = new byte[1];
		DatagramPacket bufPack = new DatagramPacket(buf,buf.length);
		System.out.println("BUFPACK: " + super.IP);
		acknowledge = new DatagramPacket(ackBuf,ackBuf.length,bufPack.getAddress(),bufPack.getPort());
		System.out.println("ACK " + new String(acknowledge.getData()));
		for(;;){
			try {
				data.receive(bufPack);
			}
			catch(java.net.SocketTimeoutException s){
				System.out.println("Did not recieve");
			}
			catch (IOException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			String sBufPack = new String(bufPack.getData());
			if(sBufPack.equals("?")){
				try {
					System.out.println(super.userName + " : " + "start sending ack ");
					data.send(acknowledge);
				} catch (IOException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
			}
		}
	}
	//TODO write this
	private void connectNextServer(){
		
	}

	
}
