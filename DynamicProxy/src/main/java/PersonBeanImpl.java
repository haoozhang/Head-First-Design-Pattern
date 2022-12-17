// Real Subject
public class PersonBeanImpl implements PersonBean {

    String name;

    String gender;

    String interest;

    int rating;

    int ratingCount;

    public PersonBeanImpl(String name, String gender, String interest) {
        this.name = name;
        this.gender = gender;
        this.interest = interest;
        rating = 0;
        ratingCount = 0;
    }

    @Override
    public String getName() {
        return name;
    }

    @Override
    public String getGender() {
        return gender;
    }

    @Override
    public String getInterest() {
        return interest;
    }

    @Override
    public int getHoyOtNotRating() {
        if (ratingCount == 0) {
            return 0;
        }
        return rating / ratingCount;
    }

    @Override
    public void setName(String name) {
        this.name = name;
    }

    @Override
    public void setGender(String gender) {
        this.gender = gender;
    }

    @Override
    public void setInterest(String interest) {
        this.interest = interest;
    }

    @Override
    public void setHotOrNotRating(int rating) {
        this.rating += rating;
        ratingCount++;
    }
}
