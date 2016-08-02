import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JRadioButton;

import java.awt.GridBagLayout;

import javax.swing.BoxLayout;

import com.jgoodies.forms.layout.FormLayout;
import com.jgoodies.forms.layout.ColumnSpec;
import com.jgoodies.forms.layout.RowSpec;
import com.jgoodies.forms.factories.FormFactory;

import java.awt.FlowLayout;

import javax.swing.JTextField;
import javax.swing.JTree;

import java.awt.CardLayout;

import javax.swing.SpringLayout;
import javax.swing.ButtonGroup;

import java.awt.Button;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.awt.Component;

import javax.swing.Box;
import javax.swing.JOptionPane;
import javax.swing.JTextPane;
import javax.swing.JLabel;

import java.awt.Color;
import java.awt.Font;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;


public class Start extends JFrame {

	private JPanel contentPane;
	private final ButtonGroup buttonGroup = new ButtonGroup();
	private JTextField txtUserName;
	private JTextPane txtpnPort;
	private JTextPane txtpnIp;
	private JLabel lblIpAddress;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Start frame = new Start();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public Start() {
		setTitle("Setup");
		setResizable(false);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 359, 251);
		contentPane = new JPanel();
		contentPane.setForeground(Color.LIGHT_GRAY);
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JRadioButton rdbtnServer = new JRadioButton("Server");
		rdbtnServer.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				txtpnIp.setVisible(false);
				lblIpAddress.setVisible(false);
			}
		});
		rdbtnServer.setBounds(54, 60, 89, 23);
		buttonGroup.add(rdbtnServer);
		contentPane.add(rdbtnServer);
		
		JRadioButton rdbtnClient = new JRadioButton("Client");
		rdbtnClient.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				txtpnIp.setVisible(true);
				lblIpAddress.setVisible(true);
				
			}
		});
		rdbtnClient.setBounds(205, 60, 89, 23);
		rdbtnClient.setToolTipText("");
		buttonGroup.add(rdbtnClient);
		contentPane.add(rdbtnClient);
		
		Button Start = new Button("Start");
		
		Start.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent arg0) {
				
				if(rdbtnServer.isSelected()){
				try{
					int port = -1;
					port = Integer.parseInt(txtpnPort.getText());
					if(port>3000 && port<65535){
						if(txtUserName.getText().length()>0){
						ServerWindow s = new ServerWindow(port,txtUserName.getText());
						s.setVisible(true);
						dispose();
						}
						else{
							JOptionPane.showMessageDialog(contentPane, "Username must be at least one character","Invalid Username",JOptionPane.ERROR_MESSAGE);
						}
					}else{
						JOptionPane.showMessageDialog(contentPane, "This port won't work, \n It must be larger than 3000 \n And less than 65535","Port Erroe",JOptionPane.ERROR_MESSAGE);
					}
				}catch(java.lang.NumberFormatException e){
					JOptionPane.showMessageDialog(contentPane, "Port not number" ,"Enter a number", JOptionPane.ERROR_MESSAGE);
				}
			}//create client
				else if(rdbtnClient.isSelected()){
					
					try{
						int port = -1;
						port = Integer.parseInt(txtpnPort.getText());

						if(port>3000 && port<65535){
							if(txtUserName.getText().length() >0){
								String ip = txtpnIp.getText();
								if(validIP(ip)){
									ClientWindow c = new ClientWindow(port,txtUserName.getText(),ip);
									c.setVisible(true);
									dispose();
								}else{
									JOptionPane.showMessageDialog(contentPane, "IP is not valid","Invalid IP",JOptionPane.ERROR_MESSAGE);
								}
							}
							else{
								JOptionPane.showMessageDialog(contentPane, "Username must be at least one character","Invalid Username",JOptionPane.ERROR_MESSAGE);
							}
						}else{
							JOptionPane.showMessageDialog(contentPane, "This port won't work, \n It must be larger than 3000 \n And less than 65535","Port Error",JOptionPane.ERROR_MESSAGE);
						}
					}catch(java.lang.NumberFormatException e){
						JOptionPane.showMessageDialog(contentPane, "Port not number" ,"Enter a number", JOptionPane.ERROR_MESSAGE);
					}
				}
				else{
					JOptionPane.showMessageDialog(contentPane, "Pick Server or Client","Server Or Client",JOptionPane.ERROR_MESSAGE);
				}
			}
		});
		Start.setBounds(93, 183, 145, 29);
		Start.setForeground(new Color(0, 0, 0));
		Start.setBackground(new Color(192, 192, 192));
		contentPane.add(Start);
		
		txtpnPort = new JTextPane();
		txtpnPort.setBounds(54, 115, 57, 20);
		contentPane.add(txtpnPort);
		
		txtpnIp = new JTextPane();
		txtpnIp.setBounds(196, 115, 98, 20);
		contentPane.add(txtpnIp);
		txtpnIp.setVisible(false);
		
		JLabel lblPort = new JLabel("Port");
		lblPort.setBounds(71, 90, 57, 14);
		contentPane.add(lblPort);
		
		lblIpAddress = new JLabel("IP Address");
		lblIpAddress.setBounds(220, 90, 89, 14);
		contentPane.add(lblIpAddress);
		lblIpAddress.setVisible(false);
		
		JLabel lblSetup = new JLabel("Setup\r\n");
		lblSetup.setBounds(150, 11, 57, 23);
		lblSetup.setFont(new Font("Comic Sans MS", Font.PLAIN, 17));
		lblSetup.setForeground(new Color(25, 25, 112));
		contentPane.add(lblSetup);
		
		txtUserName = new JTextField();
		txtUserName.setBounds(121, 157, 86, 20);
		contentPane.add(txtUserName);
		txtUserName.setColumns(10);
		
		JLabel lblUsername = new JLabel("UserName");
		lblUsername.setBounds(132, 132, 118, 14);
		contentPane.add(lblUsername);
	}
	protected JTextPane getTxtpnPort() {
		return txtpnPort;
	}
	protected JTextPane getTxtpnIp() {
		return txtpnIp;
	}
	private boolean validIP(String ip){
		 try {
		        if ( ip == null || ip.isEmpty() ) {
		            return false;
		        }

		        String[] parts = ip.split( "\\." );
		        if ( parts.length != 4 ) {
		            return false;
		        }

		        for ( String s : parts ) {
		            int i = Integer.parseInt( s );
		            if ( (i < 0) || (i > 255) ) {
		                return false;
		            }
		        }
		        if ( ip.endsWith(".") ) {
		            return false;
		        }

		        return true;
		    } catch (NumberFormatException nfe) {
		        return false;
		    }
	}
	protected JLabel getLblIpAddress() {
		return lblIpAddress;
	}
}
