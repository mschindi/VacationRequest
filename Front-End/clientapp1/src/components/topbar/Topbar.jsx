import React from 'react'
import "./topbar.css"
import { NotificationsNone, Language, Settings } from '@mui/icons-material';
import { Button } from '@material-ui/core';

export default function Topbar() {
    return (
        <div className="topbar">
            <div className="topbarWrapper">
                <div className="topLeft">
                    <span className="logo">Vacation Manager</span>
                </div>
                <div className="topRight">
                    <div className="topbarIconContainer">
                        <NotificationsNone />
                        <span className="topIconBadge">2</span>
                    </div>
                    <div className="topbarIconContainer">
                        <Language />
                        <span className="topIconBadge">2</span>
                    </div>
                    <div className="topbarIconContainer">
                        <Settings />
                    </div>
                    <img src="https://unsplash.com/photos/L2dTmhQzx4Q/download?force=true&w=640" alt="" className="topAvatar" />
                </div>
            </div>
        </div>
    )
}
