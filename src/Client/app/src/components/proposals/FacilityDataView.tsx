import React, { ChangeEvent,  useState } from "react";
import { Facility } from "../../types/proposals/Facility";
import { format, parseISO } from "date-fns";
import { getRowHeightStyle } from "../../utils/styleUtils";
import { currencyFormat } from "../../utils/AppUtils";


export type ProposalRow =
    | {
        type: 'PROPOSAL';
        proposalId: number;
        proposalName: string;
        customerGrpName: string;
        date: Date;
        description: string;
        status: string;
    }
    | {
        type: 'FACILITY';
        proposalId: number;
        facilities: Facility[]
    };

export const FacilityDataView: React.FC<{ facilities: Facility[] }> = ({ facilities }) => {
    const [facilityId, setFacilityId] = useState(facilities.length > 0 ? facilities[0].facilityId : 0)
    const handleFacilityChange = (event: ChangeEvent<HTMLSelectElement>) => {
        setFacilityId(Number(event.target.value));
    }
    const facility = facilities.find(f => f.facilityId === facilityId);

    return (
        <>
            {facility ?
                <div>
                    <div className="facility__selector" style={getRowHeightStyle(50)} >
                        <label>
                            Facility:
                            <select value={facilityId} onChange={handleFacilityChange}>
                                {
                                    facilities.map((f) => <option key={f.facilityId} value={f.facilityId}>{f.facilityName}</option>)
                                }
                            </select>
                        </label>
                    </div>
                    <div className="facility__container">
                        <div>
                            <div className="facility__field__title" style={getRowHeightStyle(30)}>Booking Country</div>
                            <div className="facility__field__content" style={getRowHeightStyle(40)}>{facility.country}</div>
                        </div>
                        <div>
                            <div className="facility__field__title" style={getRowHeightStyle(30)}>Currency</div>
                            <div className="facility__field__content" style={getRowHeightStyle(40)}>{facility.currency}</div>
                        </div>
                        <div>
                            <div className="facility__field__title" style={getRowHeightStyle(30)}>Limit({facility.currency})</div>
                            <div className="facility__field__content" style={getRowHeightStyle(40)}>{currencyFormat(facility.limit)}</div>
                        </div>
                        <div>
                            <div className="facility__field__title" style={getRowHeightStyle(30)}>Start Date</div>
                            <div className="facility__field__content" style={getRowHeightStyle(40)}>{format(parseISO(facility.startDate.toString()), 'dd/MM/yyyy')}</div>
                        </div>
                        <div>
                            <div className="facility__field__title" style={getRowHeightStyle(30)}>Maturity Date</div>
                            <div className="facility__field__content" style={getRowHeightStyle(40)}>{format(parseISO(facility.maturityDate.toString()), 'dd/MM/yyyy')}</div>
                        </div>
                    </div>

                </div>
                : <div>No facilities found</div>}
        </>
    )
}

export const MemoizedFacilityDataView = React.memo(FacilityDataView);
