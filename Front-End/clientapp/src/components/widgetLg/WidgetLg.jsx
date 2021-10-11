import "./widgetLg.css"

export default function WidgetLg() {

    const Button = ({type}) => {
        return <button className={"widgetLgButton " + type}>{type}</button>
    }
    return (
        <div className="widgetLg">
            <h3 className="widgetLgTitle">Latest transactions</h3>
            <table className="widgetLgTable">
                <tr className="widgetLgTr">
                    <th className="widgetLgTh">Customer</th>
                    <th className="widgetLgTh">Date</th>
                    <th className="widgetLgTh">Amount</th>
                    <th className="widgetLgTh">Status</th>
                </tr>
                <tr className="widgetLgTr">
                    <td className="widgetLgUser">
                        <img src="https://unsplash.com/photos/ZHvM3XIOHoE/download?force=true&w=640" alt="" className="widgetLgImg" />
                        <span className="widgetLgName">Anton Beave</span>
                    </td>
                    <td className="widgetLgDate">2 Jun 2021</td>
                    <td className="widgetLgAmount"> 122.00 €</td>
                    <td className="widgetLgStatus">
                        <Button type="Approved"/>
                        </td>
                </tr>
                <tr className="widgetLgTr">
                    <td className="widgetLgUser">
                        <img src="https://unsplash.com/photos/mEZ3PoFGs_k/download?force=true&w=640" alt="" className="widgetLgImg" />
                        <span className="widgetLgName">Susan Carol</span>
                    </td>
                    <td className="widgetLgDate">2 Jun 2021</td>
                    <td className="widgetLgAmount"> 122.00 €</td>
                    <td className="widgetLgStatus">
                        <Button type="Declined"/>
                        </td>
                </tr>
                <tr className="widgetLgTr">
                    <td className="widgetLgUser">
                        <img src="https://unsplash.com/photos/jzz_3jWMzHA/download?force=true&w=640" alt="" className="widgetLgImg" />
                        <span className="widgetLgName">Anna Pfeifer</span>
                    </td>
                    <td className="widgetLgDate">2 Jun 2021</td>
                    <td className="widgetLgAmount"> 122.00 €</td>
                    <td className="widgetLgStatus">
                        <Button type="Pending"/>
                        </td>
                </tr>
                <tr className="widgetLgTr">
                    <td className="widgetLgUser">
                        <img src="https://unsplash.com/photos/5yENNRbbat4/download?force=true&w=640" alt="" className="widgetLgImg" />
                        <span className="widgetLgName">Ching Nguyen</span>
                    </td>
                    <td className="widgetLgDate">2 Jun 2021</td>
                    <td className="widgetLgAmount"> 122.00 €</td>
                    <td className="widgetLgStatus">
                        <Button type="Approved"/>
                        </td>
                </tr>
            </table>
        </div>
    )
}
