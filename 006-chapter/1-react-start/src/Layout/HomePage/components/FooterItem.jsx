import React from "react";

const dateNow = new Date()

class FooterItem extends React.Component {
    render() {
        return(
            <div className="m-3">&copy; Авторские права мои {dateNow.getFullYear()}</div>
        )
    }
}

export default FooterItem