import React, {  useState } from "react";
import { Proposal } from "../../types/proposals/Proposal";
import DataGrid, { Column, RowsChangeData } from 'react-data-grid';
import { Facility } from "../../types/proposals/Facility";
import { FacilityDataView } from "./FacilityDataView";
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

export const ProposalDataGrid: React.FC<{ proposals: Proposal[] }> = ({ proposals }) => {
  const columns: Column<ProposalRow>[] = [
    {
      key: 'proposalName',
      name: 'Proposal Name',
      colSpan(args) {
        return args.type === 'ROW' && args.row.type === 'FACILITY' ? 6 : undefined;
      },
      cellClass(row) {
        return row.type === 'FACILITY'
          ? 'facility__cell'
          : 'proposal__cell';
      },
      formatter({ row, isCellSelected, onRowChange }) {
        if (row.type === 'FACILITY') {
          return (
            <FacilityDataView facilities={row.facilities} />
          );
        }
        return (
          <>{row.proposalName}</>
        )
      }
    },
    { key: 'customerGrpName', name: 'Customer Group' },
    { key: 'date', name: 'Date (last saved)' },
    { key: 'description', name: 'Description' },
    { key: 'status', name: 'Status' },
    {
      key: 'expanded',
      name: '',
      formatter({ row, isCellSelected, onRowChange }) {
        if (row.type === 'FACILITY') {
          return (
            <></>
          );
        }
        return (
          <span className="view__summary" onClick={() => {
            onRowChange({ ...row });
          }}>VIEW SUMMARY
          </span>
        );
      }
    },
  ];


  const proposalRows = (selectedProposalId: number): ProposalRow[] => {
    const rows: ProposalRow[] = [];
    proposals.forEach(p => {
      rows.push({
        type: 'PROPOSAL',
        proposalId: p.proposalId,
        proposalName: p.proposalName,
        customerGrpName: p.customerGrpName,
        date: p.date,
        description: p.description,
        status: p.status
      })
      if (selectedProposalId === p.proposalId) {
        rows.push({
          type: "FACILITY",
          proposalId: p.proposalId,
          facilities: p.facilities
        })
      }
    })
    return rows;
  }

  const [rows, setRows] = useState(proposalRows(-1));

  const onRowsChange = (rows: ProposalRow[], { indexes }: RowsChangeData<ProposalRow>) => {
    const newRows = proposalRows(rows[indexes[0]].proposalId)
    setRows(newRows)
  }

  return (
    <>
      <DataGrid
        columns={columns}
        rows={rows}
        onRowsChange={onRowsChange}
        headerRowHeight={45}
        rowHeight={(args) => (args.type === 'ROW' && args.row.type === 'FACILITY' ? 150 : 45)}
        className="fill-grid"
        enableVirtualization={false}
      />
    </>
  )
}

export const MemoizedProposalDataGrid = React.memo(ProposalDataGrid);

