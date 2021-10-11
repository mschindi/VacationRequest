import axios from 'axios'

const userBaseUrl = axios.create({
    baseURL: "https://localhost:5001/"
});

class UserService {
    //CREATE
    async createUsers(){
        var result = await userBaseUrl.post("User");
        console.log(result.data);
        return result.data;
    }

    // READ
    async getUsers(){
        var result = await userBaseUrl.get("User");
        console.log(result.data);
        return result;
    }


    // UPDATE
    async updateUsers(userUpdate){
        var result = await userBaseUrl.put("User", userUpdate);
        console.log(result.data);
        return result.data;
    }

    //DELETE
    async deleteUser(id){
        var result = await userBaseUrl.delete(`User?id=${id}`)
        console.log(result.data);
        return result.data;
    }

    // GetUserById
    async getUserById(id){
        var result = await userBaseUrl.get(`User/${id}`);
        console.log(result.data);
        return result;
    }
}

var userCRUDService = new UserService();
export default userCRUDService