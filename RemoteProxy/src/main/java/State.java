import java.io.Serializable;

// make this class serializable
public interface State extends Serializable {

    public void transitsA2B();

    public void transitsB2A();
}
