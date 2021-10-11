import "./user.css"
import { CalendarToday, ControlPointSharp, LocationSearching, MailOutline, PermIdentity, PhoneAndroid, Publish, Add } from "@mui/icons-material" 
import { Link } from "react-router-dom"
import { useLocation } from 'react-router-dom';
import { useEffect, useState } from "react";
import userCRUDService from "../../services/UserService";
import { DateTime } from "luxon";
import UpdateUserPopup from "../Popup/UpdateUserPopup";
import { Button } from "@material-ui/core";
import UpdateUserIndication from "../../components/Indications/UpdateUserIndication";


// A custom hook that builds on useLocation to parse
// the query string for you.
function useQuery() {
    console.log(useLocation());
    return new URLSearchParams(useLocation().search);
}

export default function User() {

    const [openPopup, setOpenPopup] = useState(false);

    let query = useQuery();
    // const getUserbyId = window.location.pathname.slice(6,7);
    // console.log(getUserbyId);

    // var currentURL = useLocation();
    // var getUserId = new URLSearchParams(currentURL);
    // var currentUserId= getUserId.get("id"); 
    // console.log(query.get("id"));
    // console.log(query.toString());
    // console.log(currentURL);
    
    const [user,setUser] = useState(
        {
            id: 0,
            username: "",
            firstName: "",
            lastName: "",
            address: "",
            email: "",
            avatar: "",
          }
    );

    const [initialUser, setInitialUser] = useState({
        id: 0,
        username: "",
        firstName: "",
        lastName: "",
        address: "",
        email: "",
        avatar: "",
      });

    useEffect(() => {
        // userCRUDService.getUsers().then((users) => {
        //   setData(users);
        // });
        async function fetchData() {
          const request = await userCRUDService.getUserById(query.get("id"));
          setUser(request.data);
          setInitialUser(request.data);
          console.log("------------SERVER USER-------------")
          console.log(request.data);
          console.log("------------INITIAL USER-------------")
          console.log(initialUser);
      }
      fetchData();

      }, []);

function handleSubmit (event){
    event.preventDefault();
    setOpenPopup(true)
}

      async function handleUpdate () {
        // setUser(user.filter((item)=>item.id !== id));
        // user.birthday = DateTime(user.birthday).toHttp();
        await userCRUDService.updateUsers(user);
        setInitialUser(user);
      };

    return (
        <div className="user">
            <div className="userTitleContainer">
                <h1 className="userTitle">Edit User</h1>
                <Link to ="/newUser">
                <button className="userAddButton">Create</button>
                </Link>
            </div>
            <div className="userContainer">
                <div className="userShow">
                    <div className="userShowTop">
                        <img src={user.avatar} alt="" className="userShowImg" />
                        <div className="userShowTopTitle">
                            <span className="userShowUsername">{user.firstName} {user.lastName}</span>
                            <span className="userShowUserTitle">{user.jobTitle}</span>
                        </div>
                    </div>
                    <div className="userShowBottom">
                        <span className="userShowTitle">Account Details</span>

                        <div className="userShowInfo">
                            <PermIdentity className="userShowIcon"/>
                            <span className="userShowInfoTitle">{user.username}</span>
                        </div>
                        <div className="userShowInfo">
                            <CalendarToday className="userShowIcon"/>
                            <span className="userShowInfoTitle">{DateTime.fromISO(user.birthday).toLocaleString()}</span>
                        </div>
                        <span className="userShowTitle">Contact Details</span>
                        <div className="userShowInfo">
                            <PhoneAndroid className="userShowIcon"/>
                            <span className="userShowInfoTitle">{user.phoneNumber}</span>
                        </div>
                        <div className="userShowInfo">
                            <MailOutline className="userShowIcon"/>
                            <span className="userShowInfoTitle">{user.email}</span>
                        </div>
                        <div className="userShowInfo">
                            <LocationSearching className="userShowIcon"/>
                            <span className="userShowInfoTitle">{user.address}</span>
                        </div>
                    </div>
                </div>
                <div className="userUpdate">
                    <span className="userUpdateTitle">Edit</span>
                    <form className="userUpdateForm" onSubmit={handleSubmit}>
                        <div className="userUpdateLeft">
                            <div className="userUpdateItem">
                                <label>Username</label>
                                <input type="text" placeholder={user.username} className="userUpdateInput" value={user.username == initialUser.username ? '' : user.username} onChange={e => setUser({...user, username: e.target.value})}/>
                            </div>
                            <div className="userUpdateItem">
                                <label>First Name</label>
                                <input type="text" placeholder= {user.firstName} className="userUpdateInput" value={user.firstName == initialUser.firstName ? '' : user.firstName} onChange={e => setUser({...user, firstName: e.target.value})}/>
                            </div>
                            <div className="userUpdateItem">
                                <label>Last Name</label>
                                <input type="text" placeholder= {user.lastName} className="userUpdateInput" value={user.lastName == initialUser.lastName ? '' : user.lastName} onChange={e => setUser({...user, lastName: e.target.value})}/>
                            </div>
                            <div className="userUpdateItem">
                                <label>Job Title</label>
                                <input type="text" placeholder={user.jobTitle} className="userUpdateInput" value={user.jobTitle == initialUser.jobTitle ? '' : user.jobTitle} onChange={e => setUser({...user, jobTitle: e.target.value})}/>
                            </div>
                            <div className="userUpdateItem">
                                <label>Email</label>
                                <input type="email" placeholder={user.email} className="userUpdateInput" value={user.email == initialUser.email ? '' : user.email} onChange={e => setUser({...user, email: e.target.value})}/>
                            </div>
                            <div className="userUpdateItem">
                                <label>Phone</label>
                                <input type="tel" placeholder={user.phoneNumber} className="userUpdateInput" value={user.phoneNumber == initialUser.phoneNumber ? '' : user.phoneNumber} onChange={e => setUser({...user, phoneNumber: e.target.value})}/>
                            </div>
                            <div className="userUpdateItem">
                                <label>Adress</label>
                                <input type="text" placeholder={user.address} className="userUpdateInput" value={user.address == initialUser.address ? '' : user.address} onChange={e => setUser({...user, address: e.target.value})}/>
                            </div>
                            <div className="userUpdateItem">
                                <label>Birthday</label>
                                <input type="text" placeholder={DateTime.fromISO(user.birthday).toLocaleString()} className="userUpdateInput" value={user.birthday == initialUser.birthday ? '' : DateTime.fromISO(user.birthday).isValid ? DateTime.fromISO(user.birthday).toLocaleString() : user.birthday} onChange={e => setUser({...user, birthday: DateTime.fromFormat(e.target.value, 'dd.MM.yyyy').toISO()})}/>
                            </div>
                        </div>
                        <div className="userUpdateRight">
                            <div className="userUpdateUpload">
                                <img className="userUpdateImg" src={user.avatar} alt="" />
                                <label htmlFor="file"><Publish className="userUpdateIcon"/></label>
                                <input type="file" id="file" style={{ display: "none" }}/>
                            </div>
                            <input type="submit" className="userUpdateButton" value="Update"/>
                            <Button
                            text= "add new"
                            variant="outlined"
                            startIcon={<Add/>} />
                        </div>
                    </form>
                </div>
            </div>
            <UpdateUserPopup
                title = "Update User"
                openPopup={openPopup} 
                setOpenPopup={setOpenPopup}>

                <UpdateUserIndication handleUpdate={handleUpdate} setOpenPopup={setOpenPopup}/>
            </UpdateUserPopup>
        </div>
    )
}
