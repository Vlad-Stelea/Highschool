import java.io.File;
import java.io.FileNotFoundException;

//done
public class Files implements Message {
	File contents;
	String sender;
	public Files(String sen,File o){
		setContents(o);
		sender =sen; 
	}
	@Override
	public String getSender() {
		return sender;
	}

	@Override
	public Object getContents() {
		return contents;
	}

	private void setContents(File o){
		// TODO Auto-generated method stub
		contents =o;
	}

}
