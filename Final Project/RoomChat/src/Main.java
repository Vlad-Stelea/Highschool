import java.io.File;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.net.InetAddress;
import java.net.SocketTimeoutException;
import java.net.UnknownHostException;


public class Main {

	public static void main(String[] args) throws SocketTimeoutException {
		Communication c = null;
		Client cl = null;
		Client cl2 = null;
		Texts m = new Texts("VLAD","test");
		Message m2 = new Texts("Client2","Sup");
		try {
			c = new Communication(null,"server",8003,false,false);
		} catch (IOException e) {
			e.printStackTrace();
		}
		System.out.println("Starting client");
		try {
			cl = new Client(c,"Client");
		} catch (IOException e) {
			e.printStackTrace();
		}
		try {
			cl2 = new Client(c,"Client 2");
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
			System.exit(0);
	}

}
