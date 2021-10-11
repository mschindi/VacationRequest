import { Dialog, DialogContent, DialogTitle, makeStyles, Typography } from '@material-ui/core';
import React from 'react'
import { createTheme, ThemeProvider } from '@mui/material';
import { Button } from "@material-ui/core";
import { PersonOutlineOutlined } from '@mui/icons-material';

// const theme = createTheme({
//     palette: {
//       success: {
//         // Purple and green play nicely together.
//         main: '#2e7d32',
//         light: '#4caf50',
//         dark: '#1b5e20',
//         contrastText: '#fff',
//       },
//       error: {
//         // This is green.A700 as hex.
//         main: '#f44336',
//       },
//       wurst: {
//         // Purple and green play nicely together.
//         main: '#2e7d32',
//         light: '#4caf50',
//         dark: '#1b5e20',
//         contrastText: '#fff',
//       },
//     },
//   });
const useStyles = makeStyles(theme =>({
    dialogWrapper :{
        padding: theme.spacing(2),
        position: 'absolute',
        top: theme.spacing(5),
    }
}))

export default function UpdateUserPopup(props) {
    
    const { title, children, openPopup, setOpenPopup } = props;
    const classes = useStyles();

    return (
        // <ThemeProvider theme={theme}>
            <Dialog open={openPopup} maxWidth="md" classes={{paper: classes.dialogWrapper}}>
                <DialogTitle>
            
                    <Typography variant="h6" component="div">
                        {title}
                    </Typography>
                
                </DialogTitle>
                <DialogContent dividers>
                <div>All Entities of your User will  be overwritten</div>
                    {children}
                </DialogContent>
            </Dialog>
        // </ThemeProvider>
    )
}
