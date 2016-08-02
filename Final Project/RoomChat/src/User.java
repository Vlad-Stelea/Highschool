import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;
import java.net.ServerSocket;
import java.net.Socket;
import java.net.SocketException;
import java.net.UnknownHostException;


public abstract class User {
	final int redirectionPort = 8054;
	protected InetAddress IP;
	protected String userName;
	protected String pcLogin;
	protected boolean isServer;
	protected DatagramSocket data;
	protected ObjectInputStream dataIn;
	protected ObjectOutputStream dataOut;
	protected boolean isRedirection = false;
	
	public User(String user) {
		userName = user;
		makePcLogin();
		makeIP();
		redirectionExists();
		//set up datagram socket
	
		
	}
	public InetAddress getIP(){
		return IP;
	}
	
	public String getUserName(){
		return userName;
	}
	
	public String getPcLogin(){
		return pcLogin;
	}
	

	
	public boolean getIsServer(){
		return isServer;
	}
	//TODO write this
	public void redirectionExists() {
		/*if(!isRedirection){
		try {
			data = new DatagramSocket();
			data.setBroadcast(true);
		} catch (SocketException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		try {
			data.setSoTimeout(1000);
		} catch (SocketException e1) {
			// TODO Auto-generated catch block
			e1.printStackTrace();
		}
		byte [] buf = "?".getBytes();
		System.out.println("IP " + IP);
		DatagramPacket bufData = new DatagramPacket(buf,buf.length,IP,redirectionPort);
		System.out.println("Data " + data.getLocalPort());
		//send test case
		try {
			data.send(bufData);
			data.receive(bufData);
			System.out.println("Buf data + : " + new String(bufData.getData()));
		}catch(java.net.SocketTimeoutException s){
			System.out.println(this.userName + " Timeout");
			isRedirection =true;
			//data.close();
			//start redirection thread
			Thread redirection = new Thread(new Runnable(){

				@Override
				public void run() {
					// TODO Auto-generated method stub
					Redirection r =new Redirection("re");
					r.doStuff();
				}
				
			});
			redirection.start();
		}catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		/*try {
			data.receive(bufData);
			
		}catch(java.net.SocketTimeoutException s){
			isRedirection =true;
			//data.close();
			//start redirection thread
			Thread redirection = new Thread(new Runnable(){

				@Override
				public void run() {
					// TODO Auto-generated method stub
					Redirection r =new Redirection("re");
					r.doStuff();
				}
				
			});
			redirection.start();
			//close out datagram over here and start over as server
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		}*/
	}
	
	public String toString(){
		return IP+":"+userName+":"+pcLogin;
	}

	
	//start of private methods
	
	private void makePcLogin(){
		pcLogin = System.getProperty("user.name");
	}
	
	private void makeIP(){
		try {
			IP = InetAddress.getLocalHost().getLocalHost();
		} catch (UnknownHostException e) {
			e.printStackTrace();
		}
	}


}
