CREATE TRIGGER trgCTPhieuMuonThem ON CTPhieuMuon
FOR INSERT
AS
BEGIN
    update PhieuMuon set TongSoSachMuon = p.TongSoSachMuon+1 from inserted i, PhieuMuon p where i.ID_PhieuMuon = p.ID
	update DocGia set SoSachMuon=SoSachMuon+1 from inserted i, DocGia g, PhieuMuon p where i.ID_PhieuMuon = p.ID and p.ID_DG = g.ID
	update Sach set SoLuongTon=SoLuongTon-1 from inserted i, Sach s where s.ID = i.ID_Sach
END

CREATE TRIGGER trgCTPhieuMuonXoa ON CTPhieuMuon
FOR DELETE
AS
BEGIN
 update PhieuMuon set TongSoSachMuon = p.TongSoSachMuon-1 from inserted i, PhieuMuon p where i.ID_PhieuMuon = p.ID
	update DocGia set SoSachMuon=SoSachMuon-1 from inserted i, DocGia g, PhieuMuon p where i.ID_PhieuMuon = p.ID and p.ID_DG = g.ID
	update Sach set SoLuongTon=SoLuongTon+1 from inserted i, Sach s where s.ID = i.ID_Sach
END

CREATE TRIGGER trgCTPhieuTraThem ON CTPhieuTra
FOR INSERT
AS
BEGIN
   update PhieuTra set SoSachTra = p.SoSachTra-1 from inserted i, PhieuTra p where i.ID_PhieuTra = p.ID
	update DocGia set SoSachMuon=SoSachMuon-1 from inserted i, DocGia g, PhieuTra p where i.ID_PhieuTra = p.ID and p.ID_DocGIa = g.ID
	update Sach set SoLuongTon=SoLuongTon+1 from inserted i, Sach s where s.ID = i.ID_Sach
END

CREATE TRIGGER trgCTPhieuTraXoa ON CTPhieuTra
FOR DELETE
AS
BEGIN
 update PhieuTra set SoSachTra = p.SoSachTra+1 from inserted i, PhieuTra p where i.ID_PhieuTra = p.ID
	update DocGia set SoSachMuon=SoSachMuon+1 from inserted i, DocGia g, PhieuTra p where i.ID_PhieuTra = p.ID and p.ID_DocGIa = g.ID
	update Sach set SoLuongTon=SoLuongTon-1 from inserted i, Sach s where s.ID = i.ID_Sach
END