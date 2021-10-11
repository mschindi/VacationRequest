import * as React from 'react';
import Button from '@mui/material/Button'
import { Add, CenterFocusStrong } from "@mui/icons-material"
import Stack from '@mui/material/Stack';




export default function UpdateUserIndication(props) 
{
    const {handleUpdate, setOpenPopup} = props;

    function UpdateAndCloseButton(event) {
        event.preventDefault();
        handleUpdate();
        setOpenPopup(false);
    }

    return (
        <Stack direction="row" spacing={2} margin={4}>
        <Button color="primary" variant="contained" onClick={UpdateAndCloseButton}>
          Update
        </Button>
        <Button variant="outlined" color="secondary">
          Decline
        </Button>
      </Stack>
    )
}
