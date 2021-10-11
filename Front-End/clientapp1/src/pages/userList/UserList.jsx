import "./userList.css"
import { DataGrid } from '@mui/x-data-grid';
import { DeleteOutline } from '@mui/icons-material';
import { Tooltip } from "@material-ui/core";
import userCRUDService from "../../services/UserService";
import { Link } from "react-router-dom";
import { useState, useEffect, createContext } from "react";
import User from "../user/User";


export default function UserList() {

  const [users,setUsers] = useState([]);

  useEffect(() => {
    // userCRUDService.getUsers().then((users) => {
    //   setData(users);
    // });
    async function fetchData() {
      const request = await userCRUDService.getUsers();
      setUsers(request.data);
  }
  fetchData();

  }, []);

  
  //Delete Funktion for the User State
 
  const handleDelete = (id) => {
    setUsers(users.filter((item)=>item.id !== id));
    userCRUDService.deleteUser(id);
  };

    const columns = [
        { field: 'id', headerName: 'ID', width: 90 },
        { field: 'user', headerName: 'User', width: 200, renderCell: (params)=>{
          return (
            <div className="userListUser">
              <img className="userListImg" src={params.row.avatar} alt=""/>
              {params.row.firstName} {params.row.lastName}
            </div>
          );
        },
       },
        { field: 'email', headerName: 'Email', width: 200 },
        {
          field: 'status',
          headerName: 'Status',
          width: 120,
        },
        {
          field: 'address',
          headerName: 'Address',
          width: 160,
        },
        {
          field:"action",
          headerName:"Action",
          width: 150,
          renderCell: (params)=>{
            return (
              <>
              <Link to={"/user/?id=" +params.row.id}>
              <button className="UserListEdit">Edit</button>
              </Link>
              <Tooltip title="Delete">
              <DeleteOutline className="UserListDelete" onClick={()=> handleDelete(params.row.id)}/>
              </Tooltip>
              </>
            )
          }
        }
      ];

  //     // User ID an eine andere Componente weitergeben
  // const userIdFromUserList = columns.row.id;

  // const UserIdContext = createContext(userIdFromUserList);

      
    return (
      <>
          <div className="userList">
            <DataGrid
              rows={users} disableSelectionOnClick
              columns={columns}
              pageSize={8} checkboxSelection
            />
          </div>

      </>
    )
}
