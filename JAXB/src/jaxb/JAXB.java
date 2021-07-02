package jaxb;

import generated.Kupci;
import generated.Kupci.Kupac;
import java.io.File;
import java.util.List;
import javax.xml.XMLConstants;
import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Unmarshaller;
import javax.xml.validation.Schema;
import javax.xml.validation.SchemaFactory;
import org.xml.sax.SAXException;


public class JAXB {

    public static void main(String[] args) {
        
        String xmlFile = "D:\\Documents\\GitHub\\IIS_Projekt\\SOAP_servis\\SOAP_servis\\Kupci.xml";
        String xsdFile = "D:\\Documents\\GitHub\\IIS_Projekt\\JAXB\\Kupci.xsd";
        
        validateXML(xmlFile,xsdFile);
    }

    private static void validateXML(String xmlFile, String xsdFile) {
        JAXBContext context;
        try
        {
            context = JAXBContext.newInstance(Kupci.class);
            
            Unmarshaller jaxbUnmarshaller = context.createUnmarshaller();
            
            SchemaFactory sf = SchemaFactory.newInstance(XMLConstants.W3C_XML_SCHEMA_NS_URI);
            Schema kupciSchema = sf.newSchema(new File(xsdFile));
            jaxbUnmarshaller.setSchema(kupciSchema);
            
            Kupci kupac = (Kupci) jaxbUnmarshaller.unmarshal(new File(xmlFile));
            List<Kupac> kupci = kupac.getKupac();
            for(Kupac kup : kupci){
                System.out.println(kup.getIme());
            }
            
        }
        catch(JAXBException |SAXException e)
        {
            e.printStackTrace();
        }
    }

   
}
