import java.lang.reflect.Proxy;

public class MatchMarketTest {

    public static void main(String[] args) {
        MatchMarketTest test = new MatchMarketTest();
        test.run();
    }

    public void run() {
        PersonBean joe = new PersonBeanImpl("Joe", "Male", "Ball");

        PersonBean ownerProxy = getOwnerProxy(joe);
        // get
        System.out.println(ownerProxy.getName());
        // set
        ownerProxy.setInterest("Game");
        // set rating
        try {
            ownerProxy.setHotOrNotRating(10);
        } catch (Exception e) {
            System.out.println("Don't allow to set rating for owner!");
        }
        System.out.println(ownerProxy.getHoyOtNotRating());

        PersonBean nonOwnerProxy = getNonOwnerProxy(joe);
        // get
        System.out.println(nonOwnerProxy.getName());
        // set
        try {
            nonOwnerProxy.setInterest("Dance");
        } catch (Exception e) {
            System.out.println("Don't allow to set interest for non-owner!");
        }
        nonOwnerProxy.setHotOrNotRating(10);
        System.out.println(nonOwnerProxy.getHoyOtNotRating());
    }

    // Create Proxy

    public PersonBean getOwnerProxy(PersonBean person) {
        return (PersonBean) Proxy.newProxyInstance(
            person.getClass().getClassLoader(),
            person.getClass().getInterfaces(),
            new OwnerInvocationHandler(person)
        );
    }

    public PersonBean getNonOwnerProxy(PersonBean person) {
        return (PersonBean) Proxy.newProxyInstance(
            person.getClass().getClassLoader(),    // the ClassLoader of person bean
            person.getClass().getInterfaces(),     // the Interface implemented by proxy
            new NonOwnerInvocationHandler(person)  // the Invocation Handler with real subject
        );
    }
}
