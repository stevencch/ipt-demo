import { Proposal } from "../types/proposals/Proposal";
import http from "./HttpCommon"

const getData = () => {
    return http.get<Proposal[]>('proposal/getData');
};

const ProposalApi = {
    getData
};

export default ProposalApi;
