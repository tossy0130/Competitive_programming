//=== 1108. Defanging an IP Address

class a_02 {
    public String defangIPaddr(String address) {

        String ans = address.replace(".", "[.]");
        return ans;
    }
}