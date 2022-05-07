import { Facility } from "./Facility";

export interface Proposal {
    proposalId:number,
    proposalName: string,
    customerGrpName:string,
    date:Date,
    description:string,
    status:string,
    facilities:Facility[]
}